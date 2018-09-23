using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class KthLargestElementInAnArray
    {
        public int FindKthLargest(int[] nums, int k)
        {
            var arr = new int[100000];
            var freq = new int[100000];

            int min = nums.Min();

            for (int i = 0; i < nums.Length; i++)
            {
                arr[nums[i] - min] = nums[i];
                freq[nums[i] - min]++;
            }


            for (int i = freq.Length - 1; i >= 0; i--)
            {
                if (freq[i] == 0) continue;

                k -= freq[i];

                if (k <= 0)
                    return arr[i];
            }

            return 0;
        }
    }
}
