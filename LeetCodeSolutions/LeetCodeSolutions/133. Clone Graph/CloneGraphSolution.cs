using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class CloneGraphSolution
    {
        public UndirectedGraphNode CloneGraph(UndirectedGraphNode node)
        {
            if (node == null) return null;

            var visited = new Dictionary<int, UndirectedGraphNode>();

            return dfs(node, visited);
        }

        private UndirectedGraphNode dfs(UndirectedGraphNode node, Dictionary<int, UndirectedGraphNode> visited)
        {

            var newNode = new UndirectedGraphNode(node.label);

            if (newNode.neighbors == null) return newNode;

            visited.Add(node.label, newNode);

            foreach (var neighbor in node.neighbors)
            {
                if (!visited.ContainsKey(neighbor.label))
                {
                    newNode.neighbors.Add(dfs(neighbor, visited));
                }
                else
                {
                    newNode.neighbors.Add(visited[neighbor.label]);
                }
            }

            return newNode;
        }
    }
}
