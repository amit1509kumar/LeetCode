using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class Permutation
    {
        public void NextPermutation(int[] nums)
        {
            int len = nums.Length;            
            int index = -1;

            //find first item to swap in reverse order
            for(int i = len - 2; i >= 0; i-- )
            {
                if (nums[i] < nums[i + 1])
                {
                    index = i;
                    break;                   
                }                   
            }

            // array is sorted in reverse order if index is -1
            if (index == -1)
            {
                Array.Sort(nums);
                return;
            }

            int numbertoSwap = nums[index + 1];

            int indextoswap = index + 1;

            for(int i = index+2; i < len; i++)
            {
                if(nums[index] < nums[i] && numbertoSwap > nums[i])
                {
                    numbertoSwap = nums[i];

                    indextoswap = i;
                }
            }

            //swap the item
            nums[indextoswap] = nums[index];

            nums[index] = numbertoSwap;

            //sort rest of the array
            Array.Sort(nums, index + 1, len - (index + 1));            
            
        }
    
}
}
