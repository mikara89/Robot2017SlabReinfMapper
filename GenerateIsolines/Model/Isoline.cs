using System.Collections.Generic;
using System.Linq;

namespace GenerateIsolines
{
    public class Isoline
    {
        public List<Node> Nodes { get; set; }
        public bool IsClosed
        {
            get
            {
                return Nodes.First().Compare(Nodes.Last());
            }
        }
        public Isoline()
        {
            Nodes = new List<Node>();
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as Isoline);
        }
        public bool Equals(Isoline obj)
        {
            return obj != null && obj.Nodes == this.Nodes && obj.IsClosed == this.IsClosed;
            // Or whatever you think qualifies as the objects being equal.
        }
    }
}



