using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class SearchTwoDMatrix
    {
        public bool SearchMatrix(int[,] matrix, int target)
        {
            int len = matrix.Length;

            if (len == 0) return false;

            int low = 0;
            int high = len - 1;
            int mid = 0;

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            while(low <= high)
            {
                mid = (high + low) / 2;

                int rIndex = mid / cols;

                int cIndex = mid % cols;

                if (matrix[rIndex, cIndex] == target)
                    return true;

                if (matrix[rIndex, cIndex] > target)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return false;

        }
    }
}
