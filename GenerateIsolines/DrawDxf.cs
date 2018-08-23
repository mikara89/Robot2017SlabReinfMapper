using GenerateIsolines.Model;
using netDxf;
using netDxf.Entities;
using netDxf.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;


namespace GenerateIsolines
{
    public class DrawDxf
    {

        private readonly FileInfo fileInfo;
        private List<Node> slabEdgthNodes;
        private List<Node> openingEdgthNodes;
        private DxfDocument dxf;
        public Vector2 LegendPosition { get;internal set; }
        public double offsetForLegend { get; set; } = 1;


        public DrawDxf(string filePath, List<Node> SlabEdgthNodes, List<Node> OpeningEdgthNodes = null)
        {
            fileInfo = new FileInfo(filePath);
            slabEdgthNodes = SlabEdgthNodes;
            openingEdgthNodes = OpeningEdgthNodes;
            dxf = new DxfDocument();

            LegendPosition=new Vector2( slabEdgthNodes.Max(x =>x.X)+ offsetForLegend, slabEdgthNodes.Max(x => x.Y) + offsetForLegend);
        }


        public void DrawIsolines(
            Tuple<List<double>, List<RSA_FE>, List<RSAColor>> fEs,
            A_Type a_Type, double SkipA, DrawAsType drawAsType = DrawAsType.SOLID)
        {
            DrawEdgth();
            DrawOpenings();
            double Areq;
            try
            {
                for (int i = 0; i < fEs.Item1.Count; i++)
                {
                    if (i == 0) Areq = 0;
                    else Areq = fEs.Item1[i - 1];
                    switch (drawAsType)
                    {
                        case DrawAsType.SOLID:
                            GetSolid(TranslateFE(Areq, a_Type, fEs.Item2, SkipA), fEs.Item3[i]);
                            GetIsoLines(TranslateFE(Areq, a_Type, fEs.Item2, SkipA), new RSAColor(255, 255, 255), fEs.Item1[i]);
                            break;
                        case DrawAsType.ISOLINES:
                           
                            GetIsoLinesV2(TranslateFE(fEs.Item1[i], a_Type, fEs.Item2, SkipA), fEs.Item3[i], fEs.Item1[i]);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error in DrawIsolines: {ex.Message}");
            }
          
        }
        private Layer CreatLayout(string disc, Color color)
        {
            disc = disc.Replace("/", "_");
            Layer layout=null;
            dxf.Layers.ToList().ForEach(x =>
            {
                if (x.Name == disc)
                    layout = x;
            });
            if (layout == null)
            {
                layout = new netDxf.Tables.Layer(disc);
                layout.Color = new AciColor(color);
            }
            dxf.Layers.Add(layout);
            return layout;
        }
        private Layer GetLayout(Color color)
        {
            Layer layout = null;
            dxf.Layers.ToList().ForEach(x =>
            {
                if (x.Color == new AciColor(color))
                    layout = x;
            });

            return layout == null ? dxf.Layers.ToList()[0] : layout;
        }

        private void GetSolid(List<FE> listFE, RSAColor color)
        {
            if (color.A == 0) return;
            var solids = new List<Solid>();
            listFE.ForEach(n =>
            {
                if (n.nodesForMapping.Count > 2)
                {
                    Node n1, n2, n3, n4, n5, n6;

                    n1 = n.nodesForMapping[0];
                    n2 = n.nodesForMapping[1];
                    n3 = n.nodesForMapping[2];
                    n4 = n.nodesForMapping.Count >= 4 ? n.nodesForMapping[3] : null;
                    n5 = n.nodesForMapping.Count >= 5 ? n.nodesForMapping[4] : null;
                    n6 = n.nodesForMapping.Count == 6 ? n.nodesForMapping[5] : null;

                    solids.Add(
                            new Solid(
                                new Vector2(n1.X, n1.Y),
                                new Vector2(n2.X, n2.Y),
                                new Vector2(n3.X, n3.Y)));
                    if (n4 != null)
                        solids.Add(
                            new Solid(
                                new Vector2(n1.X, n1.Y),
                                new Vector2(n3.X, n3.Y),
                                new Vector2(n4.X, n4.Y)));
                    if (n5 != null)
                        solids.Add(
                            new Solid(
                                new Vector2(n1.X, n1.Y),
                                new Vector2(n4.X, n4.Y),
                                new Vector2(n5.X, n5.Y)));
                    if (n6 != null)
                        solids.Add(
                            new Solid(
                                new Vector2(n1.X, n1.Y),
                                new Vector2(n5.X, n5.Y),
                                new Vector2(n6.X, n6.Y)));
                };

            });
         
            foreach (var item in solids)
            {
                item.Color = new AciColor(Color.FromArgb(color.R, color.G, color.B));
                item.Layer = GetLayout(Color.FromArgb(color.R, color.G, color.B));
                dxf.AddEntity(item);
            }
        }

     

        private void GetIsoLines(List<FE> listFE, RSAColor color, double Areq)
        {
            var z = 0;

            listFE.ForEach(x =>
            {
                for (int i = 0; i < x.nodesForMapping.Count; i++)
                {
                    var j = (i == x.nodesForMapping.Count - 1) ? 0 : i + 1;
                    if (!(x.nodes.Any(c => c == x.nodesForMapping[i]) || x.nodes.Any(c => c == x.nodesForMapping[j])))
                    {
                        var n1 = x.nodesForMapping[i];
                        var n2 = x.nodesForMapping[j];
                        dxf.AddEntity(new Line(
                           new Vector2(n1.X, n1.Y),
                           new Vector2(n2.X, n2.Y))
                        { Color = new AciColor(Color.FromArgb(color.R, color.G, color.B)) });

                        if (z % 40 == 0)
                        {
                            var text = new MText();
                            text.Color = new AciColor(Color.FromArgb(color.R, color.G, color.B));
                            text.Position = new Vector3(Node.GetMiddleNode(n1, n2).X, Node.GetMiddleNode(n1, n2).Y, 0);
                            text.Rotation = Node.GetDegreeNode(n1, n2);
                            text.AttachmentPoint = MTextAttachmentPoint.MiddleCenter;
                            text.Height = 0.1;
                            text.Value = Areq.ToString();
                            dxf.AddEntity(text);
                        }
                    }
                    z++;
                }
            });
        }

        private void GetIsoLinesV2(List<FE> listFE, RSAColor color, double Areq) 
        {
            var z = 0;
            var ListOfIsolines = GeneratorOfIsolines.GetIsoLines(listFE, Areq);
            ListOfIsolines.ForEach(x =>
            {
                
                List<PolylineVertex> pv = new List<PolylineVertex>();
                x.Nodes.ForEach(y => pv.Add(new PolylineVertex(y.X, y.Y, 0)));
                dxf.AddEntity(new Polyline(pv,x.IsClosed)
                { Color = new AciColor(Color.FromArgb(color.R, color.G, color.B)),
                 
                    Lineweight = Lineweight.W15 }

                );
                var n1 = x.Nodes[x.Nodes.Count / 2];
                var n2 = x.Nodes[(x.Nodes.Count + 1) / 2];
                var text = new MText();
                text.Color = new AciColor(Color.FromArgb(color.R, color.G, color.B));
                text.Position = new Vector3(Node.GetMiddleNode(n1, n2).X, Node.GetMiddleNode(n1, n2).Y, 0);
                text.Rotation = Node.GetDegreeNode(n1, n2);
                text.AttachmentPoint = MTextAttachmentPoint.MiddleCenter;
                text.Height = 0.1;
                text.Value = Areq.ToString();
                dxf.AddEntity(text);

            });

        }


        private void HelpDrawFE(List<FE> listFE)
        {
            listFE.ForEach(n =>
            {
                n.nodes.ForEach(v =>
                {
                    dxf.AddEntity(new Circle(new Vector2(v.X,v.Y),0.01));
                });
            });
        }  
        private void DrawEdgth() 
        {
            if (slabEdgthNodes != null)
                ConnectNodes(slabEdgthNodes);
        }
        private void DrawOpenings()
        {
            if(openingEdgthNodes!=null)
                ConnectNodes(openingEdgthNodes);
        }

        private void ConnectNodes(List<Node> Nodes) 
        {
            var pV = new List<PolylineVertex>();
            Nodes.ForEach(x =>
            {
                pV.Add(new PolylineVertex(x.X, x.Y, 0));
            });

            dxf.AddEntity(new Polyline(pV.AsEnumerable(), true));
        }

        public void SaveDrawing()
        {
            dxf.Save(fileInfo.FullName);
        }

        private List<FE> TranslateFE(double Areq, A_Type a_Type, List<RSA_FE> Panel, double SkipA)
        {
            List<FE> l = new List<FE>();
            Panel.ForEach(x =>
            {
                var e = new FE();
                e.ConvertFromRSA_FEToFE(x, a_Type);
                l.Add(e);
            });
            var v = new GeneratorOfIsolines(l);
            return v.GetNewNodesInFE((Areq+ SkipA));
        }

        public void DrawLegend(Legend legend )
        {
            Vector2 position = LegendPosition;
            //Footer 
            Vector3 p1, p2, p3, p4;
            var width = 2.5;
            p1 = new Vector3(position.X, position.Y, 0);
            p2 = new Vector3(position.X + width, position.Y, 0);
            p3 = new Vector3(position.X + width, position.Y + 0.30, 0);
            p4 = new Vector3(position.X, position.Y + 0.30, 0);

            var fpoints = new List<Vector3>()
            {
               new Vector3(position.X, position.Y, 0),
               new Vector3(position.X + width, position.Y, 0),
               new Vector3(position.X + width, position.Y + 0.30, 0),
               new Vector3(position.X, position.Y + 0.30, 0)
             };
            var footer = new Polyline(fpoints, true);
            var footerText = new MText()
            {
                Position = new Vector3(position.X + 0.06, position.Y + 0.06, 0),
                Value = $"Extrime= {legend.Extrime} cm2/m",
                AttachmentPoint = MTextAttachmentPoint.BottomLeft,
                Height = 0.13,
            };

            //body
            double n = 0;
            n = 0.25/*+0.30*/ + legend.ListOfLagendItems.Count * 0.28;
            var nText = 0.28;
            var bpoints = new List<Vector3>()
            {
               new Vector3(position.X, position.Y + 0.30, 0),
               new Vector3(position.X + width, position.Y + 0.30, 0),
               new Vector3(position.X + width, position.Y + n, 0),
               new Vector3(position.X, position.Y+ n, 0),
            };
            var body = new Polyline(bpoints, true);
            var textPos = new Vector3(position.X + 0.60, position.Y+ 0.25, 0);
            var solidPos = new Vector2(position.X+ width-0.7, position.Y + 0.25);
            var nSolid = 0.28;
            List<MText> mTexts = new List<MText>();
            List<Solid> solids = new List<Solid>();
          
            legend.ListOfLagendItems.ForEach(
                x => {
                    CreatLayout(x.Discription, Color.FromArgb(x.Color.A, x.Color.R, x.Color.G, x.Color.B));
                    if (x.Color.A != 0)
                    {
                        mTexts.Add(
                        new MText
                        {
                            AttachmentPoint = MTextAttachmentPoint.BottomLeft,
                            Height = 0.13,
                            Position = textPos,
                            Value = $"{x.Discription}"
                        });
                        
                        solids.Add(
                            new Solid(
                                solidPos,
                                new Vector2(solidPos.X + 0.6, solidPos.Y),
                                new Vector2(solidPos.X, solidPos.Y + 0.2),
                                new Vector2(solidPos.X + 0.60, solidPos.Y + 0.2))
                            {
                                Color = new AciColor(
                                    Color.FromArgb(x.Color.A,x.Color.R, x.Color.G, x.Color.B)),
                            }
                        );
                    }
                    
                    textPos.Y += nText;
                    solidPos.Y += nSolid;
                    }
        
            );

            dxf.AddEntity(footer);
            dxf.AddEntity(footerText);
            dxf.AddEntity(body);
            mTexts.ForEach(x => dxf.AddEntity(x));
            solids.ForEach(x => dxf.AddEntity(x));
        }
    }
}