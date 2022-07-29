using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.Graphs
{
    public class Edge
    {
        public int sourceNode { get; set; }
        public int destinationNode { get; set; }

        public Edge(int sourceNode, int destinationNode)
        {
            this.sourceNode = sourceNode;
            this.destinationNode = destinationNode;
        }
    }
}
