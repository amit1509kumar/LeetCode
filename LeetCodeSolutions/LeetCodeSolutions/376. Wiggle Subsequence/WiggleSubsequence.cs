using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions._376._Wiggle_Subsequence
{
    public class WiggleSubsequence
    {
              
        public int WiggleMaxLength(int[] nums)
        {

            if (nums == null || nums.Length < 1) return 0;

            return Math.Max(Check(nums, 0), Check(nums, 1)) + 1;
        }


        public int Check(int[] nums, int last)
        {
            int ans = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1]) continue;

                int currBit = nums[i] - nums[i - 1] < 0 ? 0 : 1;

                if (currBit == (last ^ 1)) ans++;

                last = currBit;

            }

            return ans;

        }
    }
}

