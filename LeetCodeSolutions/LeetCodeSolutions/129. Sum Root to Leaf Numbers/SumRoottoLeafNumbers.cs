using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class SumRoottoLeafNumbers
    {
        private int result = 0;
        public int SumNumbers(TreeNode root, int sum = 0)
        {

            if (root == null) return result;

            if (root.left == null && root.right == null)
                result = result + sum * 10 + root.val;

            SumNumbers(root.left, sum * 10 + root.val);

            SumNumbers(root.right, sum * 10 + root.val);

            return result;
        }
    }
}
