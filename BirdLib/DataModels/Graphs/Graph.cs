using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.Graphs
{
    public class Graph
    {
        private List<Edge> _edges;

        public Graph(List<Edge> edges)
        {
            _edges = edges;
        }

        public IReadOnlyList<Edge> Edges
        {
            get { return _edges.AsReadOnly(); }
        }
    }
}
