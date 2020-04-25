using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions._1130_Minimum_Cost_Tree_From_Leaf_Values
{
   public class MinimumCostTreeFromLeafValues
    {
        public int LongestZigZag(TreeNode root)
        {
            var q = new Queue<object[]>();
            q.Enqueue(new object[] { root, 0, "root" });

            int ans = 0;

            while (q.Count > 0)
            {
                var c = q.Count;

                for (int i = 0; i < c; i++)
                {
                    var node = q.Dequeue();

                    ans = Math.Max(ans, Convert.ToInt32(node[1]));

                    var treeNode = node[0] as TreeNode;
                    if (treeNode.left != null)
                    {
                        if (node[2] == "right" || node[2] == "root")
                            q.Enqueue(new object[] { treeNode.left, (int)node[1] + 1, "left" });
                        else
                            q.Enqueue(new object[] { treeNode.left, 1, "left" });

                    }

                    if (treeNode.right != null)
                    {
                        if (node[2] == "left" || node[2] == "root")
                            q.Enqueue(new object[] { treeNode.right, (int)node[1] + 1, "right" });
                        else
                            q.Enqueue(new object[] { treeNode.right, 1, "right" });

                    }

                }



            }

            return ans;

        }


    }
}
