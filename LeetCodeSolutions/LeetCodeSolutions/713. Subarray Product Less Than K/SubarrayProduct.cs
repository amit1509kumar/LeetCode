/* the idea is to use sliding window technique to
 * keep multiplication window value smaller than k  */
namespace LeetCodeSolutions
{
   public class SubarrayProduct
    {
        public int NumSubarrayProductLessThanK(int[] nums, int k)
        {

            int res = 0;
            int mul = 1;

            for (int i = 0, j = 0; i < nums.Length; i++)
            {
                mul *= nums[i];

                while (j <= i && mul >= k)
                {
                    mul /= nums[j];

                    j++;
                }

                res += i - j + 1;
            }

            return res;

        }
    }
}
