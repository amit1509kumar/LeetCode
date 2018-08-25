/*
 *Single Element in a Sorted Array O(logn) solution 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class SingleElementSortedArray
    {
        public int SingleNonDuplicate(int[] nums)
        {
            int len = nums.Length;

            if (nums.Length < 2) return -1;

            if (nums[0] != nums[1]) return nums[0];

            if (nums[len - 1] != nums[len - 2]) return nums[len - 1];

            int left = 0;
            int right = nums.Length;
            int mid = 0;
            while(left < right)
            {
                mid = left + (right - left) / 2;

                if (nums[mid] != nums[mid + 1] && nums[mid] != nums[mid - 1])
                    return nums[mid];

                if ((nums[mid] == nums[mid + 1] && mid % 2 == 0 )
                    || (nums[mid] == nums[mid - 1] && mid % 2 != 0))
                    left = mid;
                else
                    right = mid;
            }


            return -1;



        }
    }
}
