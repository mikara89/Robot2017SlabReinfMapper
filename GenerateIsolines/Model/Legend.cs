using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateIsolines.Model
{
    public class Legend
    {
        public List<LegendItem> ListOfLagendItems { get; set; }
        public double   Extrime { get ; set ; }
        public string LegendOfType { get; set; }
        public int slabNumber { get; set; }  

        public Legend()

        {
            ListOfLagendItems = new List<LegendItem>();
        }
    }



    public class LegendItem
    {
        private string _discription;
        private double _areg;
        private RSAColor _color;

        public string Discription
        {
            get => _discription;
            set { _discription=value; }
        }
        public double Areg
        {
            get => _areg;
            set { _areg = value; }
        }
        public RSAColor Color
        {
            get => _color;
            set { _color = value; }
        }
    }
}
