using BirdLib.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib.ExtensionMethods
{
    public static class GraphExtension
    {
        public static HashSet<int> GetReachableNodesFrom(this Graph graph, int sourceNode)
        {
            var graphDove = new GraphDove();
            return graphDove.GetReachableNodes(graph, sourceNode);
        }
    }
}
