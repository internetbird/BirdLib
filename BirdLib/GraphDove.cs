using BirdLib.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdLib
{
    public class GraphDove
    {

        /// <summary>
        /// Returns all reachable nodes from source node 
        /// by using the BFS algorithm
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="sourceNode"></param>
        /// <returns></returns>
        public HashSet<int> GetReachableNodes(Graph graph, int sourceNode)
        {
            var reachableNodes = new HashSet<int> { sourceNode};

            var searchQueue = new Queue<int>();
            searchQueue.Enqueue(sourceNode);

            while (searchQueue.Any())
            {
                var node = searchQueue.Dequeue();
                List<int> neighbours = GetAllNodeNeighbours(graph, node);

                var nonExploredNodes = neighbours.FindAll(node => !reachableNodes.Contains(node));

                foreach (int nonExploredNode in nonExploredNodes)
                {
                    reachableNodes.Add(nonExploredNode);
                    searchQueue.Enqueue(nonExploredNode);
                }
            }
            return reachableNodes;
        }

        /// <summary>
        /// Returns all the nodes that are reachable from the given node
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private List<int> GetAllNodeNeighbours(Graph graph, int node)
        {
            return graph.Edges
                .Where(edge => edge.sourceNode == node)
                .Select(edge => edge.targetNode).ToList();
            
        }
    }
}
