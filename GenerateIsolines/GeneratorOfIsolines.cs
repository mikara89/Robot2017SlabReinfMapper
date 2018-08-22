using GenerateIsolines.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace GenerateIsolines
{
    /// <summary>
    /// Class for Creating nodes for isolines from FE 
    /// </summary>
    public class GeneratorOfIsolines
    {
        /// <summary>
        /// Property for list of FE from slab
        /// </summary>
        public List<FE> fe_list { get; internal set; } 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fe_list">List of FE from slab</param>
        public GeneratorOfIsolines(List<FE> fe_list)
        {
            this.fe_list = fe_list;
        }


        private IEnumerable<FE> Filter(double Areq)
        {
            for (int i = 0; i < fe_list.Count; i++)
            {
                int LowerThenSearch = 0;
                int GreaterThenSearch = 0;
                for (int j = 0; j < fe_list[i].nodes.Count; j++)
                {
                    if (fe_list[i].nodes[j].A < Areq) LowerThenSearch++;
                    else GreaterThenSearch++;
                }

                if (LowerThenSearch > 0 && GreaterThenSearch > 0) yield return fe_list[i];
                if (GreaterThenSearch == fe_list[i].nodes.Count) yield return fe_list[i];
            }
        }


        /// <summary>
        /// Returns list of FE with filtred and filled list of nodesForMapping
        /// </summary>
        /// <param name="Areq">For filtring</param>
        /// <returns></returns>
        public List<FE> GetNewNodesInFE(double Areq)
        {
            var Result = new List<FE>();
            var list = Filter(Areq).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                list[i] = GetNewFEFrom4And3Nodes(list[i], Areq);
            }
            return list;
        }


        private FE GetNewFEFrom4And3Nodes(FE fE, double Areq)
        {
            for (int i = 0; i < fE.nodes.Count; i++)
            {
                var j = (i == fE.nodes.Count - 1) ? 0 : i + 1;
                if (fE.nodes[i].A > Areq) fE.nodesForMapping.Add(fE.nodes[i]);
                var n = PointSearcher(fE.nodes[i], fE.nodes[j], Areq);
                if (n != null) fE.nodesForMapping.Add(n);

            }
            return fE;
        }

        public static List<Isoline> GetIsoLines(List<FE> listFE, double Areq)
        {
            var ListofLines = new List<Isoline>();
            var ListOfIsolines = new List<Isoline>();
            listFE.ForEach(x =>
            {
                for (int i = 0; i < x.nodesForMapping.Count; i++)
                {
                    var j = (i == x.nodesForMapping.Count - 1) ? 0 : i + 1;
                    if (!(x.nodes.Any(c => c == x.nodesForMapping[i]) || 
                    x.nodes.Any(c => c == x.nodesForMapping[j])))
                    {
                        var I = new Isoline();
                        I.Nodes.Add(x.nodesForMapping[i]);
                        I.Nodes.Add(x.nodesForMapping[j]);
                        ListofLines.Add(I);
                    }
                }
            });

            if (ListofLines.Count == 0) return new List<Isoline>(); 

            return FilterIsoline(ListofLines); ;
        }



        private static List<Isoline> FilterIsoline(List<Isoline> ListofLines)
        {
            var listNewIsolines = new List<Isoline>();
            var backingList = ListofLines;
            try
            {
                do
                {
                    var t = true;
                    var line = backingList[0];
                    backingList.Remove(line);
                    var removed = new List<Isoline>(); 
                    do
                    {                        
                        Isoline line2 = null;
                        for (int i = 0; i < backingList.Count; i++)
                        {
                            if(backingList[i].Nodes.First().Compare(line.Nodes.First()) ||
                                backingList[i].Nodes.Last().Compare(line.Nodes.First()) ||
                                backingList[i].Nodes.Last().Compare(line.Nodes.Last()) ||
                                backingList[i].Nodes.First().Compare(line.Nodes.Last())
                                )
                            {
                                if (!CompereListAndIsoline(removed, backingList[i]))
                                {
                                    line2 = backingList[i];
                                    break;
                                }
                        }

                        }
                        if (line2 != null)
                        {
                            line = AddTwoIsolines(line, line2);
                            removed.Add(line2);
                            backingList.Remove(line2);
                        }
                        t = line2 != null;
                    } while (t);
                    listNewIsolines.Add(line);
                } while (backingList.Count != 0);
            }
            catch (Exception ex)
            {

                throw new Exception($"Error in GeneratorForNodesForIsolines.GetIsoLinesV2: {ex.Message}");
            }


            return listNewIsolines;
        }

        private static bool CompereListAndIsoline(List<Isoline> isolines, Isoline isoline)
        {
            bool t=false;
            isolines.ForEach(x =>
            {
                if (x.Nodes.First().Compare(isoline.Nodes.First()) &&
                x.Nodes.Last().Compare(isoline.Nodes.Last())) t= true; ///Use Compere
                if (x.Nodes.Last().Compare(isoline.Nodes.First()) &&
                x.Nodes.First().Compare(isoline.Nodes.Last())) t = true; ///Use Compere
                if (x.Nodes.Last().Compare(isoline.Nodes.Last()) &&
                x.Nodes.First().Compare(isoline.Nodes.First())) t = true; ///Use Compere
            });
            return t;
        }


        private static Isoline AddTwoIsolines(Isoline line, Isoline line2)
        {
            //Detrment if connect to start or to end

            if (line.Nodes.First().Compare(line2.Nodes.Last()))
            {
                for (int i = 1; i < line2.Nodes.Count; i++)
                {
                    line.Nodes.Insert(0, line2.Nodes[line2.Nodes.Count - 1 - i]);
                }
            }
            if (line.Nodes.Last().Compare(line2.Nodes.First()))
            {
                for (int i = 1; i < line2.Nodes.Count; i++)
                {
                    line.Nodes.Add(line2.Nodes[i]);
                }
            }

            //Add node to line one by one

            // return line
            return line;
        }



        private Node PointSearcher(Node n2, Node n1, double Areq)
        {
            if ((n1.A > Areq && n2.A < Areq) ||
             (n1.A < Areq && n2.A > Areq))
            {
                var deltA = n1.A - n2.A;
                var deltAreg = Areq - n1.A;
                var deltaX = n1.X - n2.X;
                var deltaY = n1.Y - n2.Y;

                var x = n1.X + Interpulation(deltaX, deltA, deltAreg);
                var y = n1.Y + Interpulation(deltaY, deltA, deltAreg);
                var A = n1.A + deltAreg;
                if (Math.Round(A,3) != Math.Round(Areq,3))
                    throw new Exception($"Error: A={A} a Areg={Areq}");
                return new Node() { X = x, Y = y, A = A };

            }
            if (n1.A == Areq) return n1;
            if (n2.A == Areq) return n2;

            return null;
        }

        private double Interpulation(double x1, double val1, double val2)
        {
            return (1 / (val1 / x1)) * val2;
        }



    }

}