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
    public interface IDrawDxfParametars
    {
        List<Node> slabEdgesNodes { get; set; }
        Legend Legend { get; set; }
        List<RSA_FE> ListFe { get; set; }
        DrawAsType drawAsType { get; set; }
        A_Type a_Type { get; set; }
        double SkipA { get; set; }
    }
    public class DrawDxfParametars: IDrawDxfParametars
    {
        public List<Node> slabEdgesNodes { get; set; }
        public Legend Legend { get; set; }
        public List<RSA_FE> ListFe { get; set; }
        public DrawAsType drawAsType { get; set; }
        public A_Type a_Type { get; set; }
        public double SkipA { get; set; }
    }

    public class DrawDxf
    {
        private DxfDocument dxf;
        public Vector2 LegendPosition { get; internal set; } 
        public double offsetForLegend { get; set; } = 1;
        public IDrawDxfParametars Parm { get; }

        public DrawDxf(IDrawDxfParametars parm)
        {
            Parm = parm;
            dxf = new DxfDocument();

            LegendPosition = new Vector2
                (
                    Parm.slabEdgesNodes.Max(x => x.X) + offsetForLegend, 
                    Parm.slabEdgesNodes.Max(x => x.Y) + offsetForLegend
                );
            
        }

        /// <summary>
        /// Draw solid or isolines
        /// </summary>
        /// <returns></returns>
        public DrawDxf DrawIsolines()
        {
            double Areq;
            try
            {
                for (int i = 0; i < Parm.Legend.ListOfLagendItems.Count(); i++)
                {
                    if (i == 0) Areq = 0;
                    else Areq = Parm.Legend.ListOfLagendItems[i - 1].Areg;
                    switch (Parm.drawAsType)
                    {
                        case DrawAsType.SOLID:
                            GetSolid(
                                TranslateFE(
                                    Areq,
                                    Parm.a_Type, 
                                    Parm.ListFe, 
                                    Parm.SkipA), 
                                Parm.Legend.ListOfLagendItems[i].Color, 
                                Parm.Legend.ListOfLagendItems[i].Discription);
                            GetIsoLines(
                                TranslateFE(
                                    Areq,
                                    Parm.a_Type,
                                    Parm.ListFe, 
                                    Parm.SkipA),
                                new RSAColor(255, 255, 255),
                                Parm.Legend.ListOfLagendItems[i].Areg,
                                Parm.Legend.ListOfLagendItems[i].Discription);
                            break;
                        case DrawAsType.ISOLINES:
                            GetIsoLinesV2(
                                TranslateFE(
                                    Areq,
                                    Parm.a_Type, 
                                    Parm.ListFe,
                                    Parm.SkipA), 
                                Parm.Legend.ListOfLagendItems[i].Color,
                                Parm.Legend.ListOfLagendItems[i].Areg,
                                Parm.Legend.ListOfLagendItems[i].Discription);
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
            return this;
        }


        private Layer CreatLayer(string disc, Color color)
        {
            disc = disc.Replace("/", "_");
            Layer layout = null;
            dxf.Layers.ToList().ForEach(x =>
            {
                if (x.Name == disc)
                    layout = x;
            });
            if (layout == null)
            {
                layout = new Layer(disc);
                layout.Color = new AciColor(color);
            }
            dxf.Layers.Add(layout);
            return layout;
        }

        /// <summary>
        /// Create layers from Legend(Scale)
        /// </summary>
        /// <returns></returns>
        public DrawDxf CreatAllLayer()
        {
            Parm.Legend.ListOfLagendItems.ForEach(x =>
            {
               var disc = x.Discription.Replace("/", "_");
                dxf.Layers.Add(new Layer(disc)
                {
                    Color =new AciColor(Color.FromArgb(x.Color.R, x.Color.G, x.Color.B))
                });
            });
            return this;
        }

        private Layer GetLayer(string disc)
        {
            disc = disc.Replace("/", "_");
            if (!dxf.Layers.Any(x => x.Name == disc)) return dxf.Layers.ToList()[0];

            return dxf.Layers.First(x=>x.Name==disc);
        }

        private void GetSolid(List<FE> listFE, RSAColor color, string layer)
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
                item.Layer = GetLayer(layer);
                dxf.AddEntity(item);
            }
        }



        private void GetIsoLines(List<FE> listFE, RSAColor color, double Areq, string layer)
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
                        {
                            Color = new AciColor(Color.FromArgb(color.R, color.G, color.B)),
                            Layer =GetLayer(layer)
                        });

                        //if (z % 40 == 0)
                        //{
                        //    var text = new MText();
                        //    text.Color = new AciColor(Color.FromArgb(color.R, color.G, color.B));
                        //    text.Position = new Vector3(Node.GetMiddleNode(n1, n2).X, Node.GetMiddleNode(n1, n2).Y, 0);
                        //    text.Rotation = Node.GetDegreeNode(n1, n2);
                        //    text.AttachmentPoint = MTextAttachmentPoint.MiddleCenter;
                        //    text.Height = 0.1;
                        //    text.Value = Areq.ToString();
                        //    dxf.AddEntity(text);
                        //}
                    }
                    z++;
                }
            });
        }

        private void GetIsoLinesV2(List<FE> listFE, RSAColor color, double Areq, string layer)
        {
            var z = 0;
            var ListOfIsolines = GeneratorOfIsolines.GetIsoLines(listFE, Areq);
            ListOfIsolines.ForEach(x =>
            {

                List<PolylineVertex> pv = new List<PolylineVertex>();
                x.Nodes.ForEach(y => pv.Add(new PolylineVertex(y.X, y.Y, 0)));
                dxf.AddEntity(new Polyline(pv, x.IsClosed)
                {
                    Color = new AciColor(Color.FromArgb(color.R, color.G, color.B)),
                    Layer = GetLayer(layer),
                    Lineweight = Lineweight.W15
                }

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
                text.Layer = GetLayer(layer);
                dxf.AddEntity(text);

            });

        }

        /// <summary>
        /// Draw edges of slab
        /// </summary>
        /// <returns></returns>
        public DrawDxf DrawEdges()
        {
            if (Parm.slabEdgesNodes != null)
                ConnectNodes(Parm.slabEdgesNodes);
            return this;
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


        /// <summary>
        /// Saves dxf file on given location
        /// </summary>
        /// <param name="filePath">Path to created file</param>
        /// <returns></returns>
        public DrawDxf SaveDrawing(string filePath) 
        {
            var fileInfo = new FileInfo(filePath);
            dxf.Save(fileInfo.FullName);
            return this;
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
            return v.GetNewNodesInFE((Areq + SkipA));
        }


        /// <summary>
        /// Create Lengend/Scale in drawing
        /// </summary>
        /// <returns></returns>
        public DrawDxf DrawLegend()
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
                Value = $"Extrime= {Parm.Legend.Extrime} cm2/m",
                AttachmentPoint = MTextAttachmentPoint.BottomLeft,
                Height = 0.13,
            };

            //body
            double n = 0;
            n = 0.25/*+0.30*/ + Parm.Legend.ListOfLagendItems.Count * 0.28;
            var nText = 0.28;
            var bpoints = new List<Vector3>()
            {
               new Vector3(position.X, position.Y + 0.30, 0),
               new Vector3(position.X + width, position.Y + 0.30, 0),
               new Vector3(position.X + width, position.Y + n, 0),
               new Vector3(position.X, position.Y+ n, 0),
            };
            var body = new Polyline(bpoints, true);
            var textPos = new Vector3(position.X + 0.60, position.Y + 0.25, 0);
            var solidPos = new Vector2(position.X + width - 0.7, position.Y + 0.25);
            var nSolid = 0.28;
            List<MText> mTexts = new List<MText>();
            List<Solid> solids = new List<Solid>();

            Parm.Legend.ListOfLagendItems.ForEach(
                x => {
                    CreatLayer(x.Discription, Color.FromArgb(x.Color.A, x.Color.R, x.Color.G, x.Color.B));
                    if (x.Color.A != 0)
                    {
                        mTexts.Add(
                        new MText
                        {
                            AttachmentPoint = MTextAttachmentPoint.BottomLeft,
                            Height = 0.13,
                            Position = textPos,
                            Value = x.Discription == "Max" ? $"{x.Discription}({Math.Round(x.Areg, 2)})" : $"{x.Discription}"
                        });

                        solids.Add(
                            new Solid(
                                solidPos,
                                new Vector2(solidPos.X + 0.6, solidPos.Y),
                                new Vector2(solidPos.X, solidPos.Y + 0.2),
                                new Vector2(solidPos.X + 0.60, solidPos.Y + 0.2))
                            {
                                Color = new AciColor(
                                    Color.FromArgb(x.Color.A, x.Color.R, x.Color.G, x.Color.B)),
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

            return this;
        }
    }
}