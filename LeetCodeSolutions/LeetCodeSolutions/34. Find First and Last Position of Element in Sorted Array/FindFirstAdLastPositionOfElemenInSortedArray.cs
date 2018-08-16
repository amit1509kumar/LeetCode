using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
   public class FindFirstAdLastPositionOfElemenInSortedArray
   {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[] { -1, -1 };

            return new int[] { SearchInLeftSubArray (nums,target),
                             SearchInRightSubArray(nums, target)};
        }

        public int SearchInLeftSubArray(int[] nums,int target)
        {
            int left = -1;
            int right = nums.Length -1 ;
            int mid = 0;

            while(right - left > 1)
            {
                mid = (left + right) / 2;

                if (nums[mid] < target)
                    left = mid;
                else
                    right = mid;
            }




            if (nums[left + 1] == target)
                return left + 1;
            else
                return -1;
        }

        public int SearchInRightSubArray(int[] nums,int target)
        {
            int left = 0;
            int right = nums.Length;
            int mid = 0;

            while (right - left > 1)
            {
                mid = (left + right) / 2;                

                if (nums[mid] > target)
                    right = mid;
                else
                    left = mid;
            }

            if (nums[right - 1] == target)
                return right - 1;
            else
                return -1;
        }
    }
}
