
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class SerializeAndDeserializeBinaryTree
    {
        // Encodes a tree to a single string using BFS
        public string serialize(TreeNode root)
        {
            if (root == null) return null;

            var q = new Queue<TreeNode>();

            q.Enqueue(root);

            var ans = new StringBuilder();


            while (q.Count != 0)
            {
                int n = q.Count;

                for (int i = 0; i < n; i++)
                {
                    var item = q.Dequeue();

                    ans.Append(item == null ? "," :
                               item.val.ToString() + ",");

                    if (item == null) continue;

                    q.Enqueue(item.left);


                    q.Enqueue(item.right);

                }
            }


            return ans.ToString();

        }

        int i = 0;

        // Decodes your encoded data to tree using BFS
        public TreeNode deserialize(string data)
        {

            if (data == null) return null;

            var root = new TreeNode(ReadNum(data));
            var q = new Queue<TreeNode>();
            i++;
            q.Enqueue(root);


            while (q.Count != 0)
            {


                int n = q.Count;

                for (int k = 0; k < n; k++)
                {
                    var item = q.Dequeue();

                    if (i < data.Length && data[i] != ',')
                    {
                        item.left = new TreeNode(ReadNum(data));
                        q.Enqueue(item.left);
                    }

                    i++;

                    if (i < data.Length && data[i] != ',')
                    {
                        item.right = new TreeNode(ReadNum(data));
                        q.Enqueue(item.right);
                    }

                    i++;

                }

            }

            return root;
        }


        private int ReadNum(string str)
        {
            var isNeg = false;
            if (str[i] == '-')
            {
                isNeg = true;
                i++;
            }

            int num = 0;

            while (i < str.Length && str[i] != ',')
            {
                num = num * 10 + (str[i] - '0');
                i++;
            }

            Console.WriteLine(num);
            return isNeg ? -num : num;


        }
    }
}

