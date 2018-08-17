using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int len = nums.Length;

            if (len == 0) return -1;

            if (target < nums[0]) return 0;

            if (target > nums[len - 1]) return len;

            int low = -1;

            int high = nums.Length - 1;

            int mid = 0;

            while(high - low > 1)
            {
                mid = (low + high) / 2;

                if (nums[mid] <= target)
                    low = mid;
                else
                    high = mid;
            }

            if (low > -1 && nums[low] == target)
                return  low;

            return low + 1;

        }
    }
}
