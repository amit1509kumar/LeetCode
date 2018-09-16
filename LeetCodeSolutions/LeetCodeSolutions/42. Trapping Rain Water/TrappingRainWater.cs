using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {

            int left = 0;
            int right = height.Length - 1;
            int water = 0;

            while (left < height.Length && height[left] == 0)
            {
                left++;
            }

            while (right >= 0 && height[right] == 0)
            {
                right--;
            }

            if (right < 0 || left >= height.Length) return 0;

            int maxLeft = height[left];
            int maxRight = height[right];

            while (left < right)
            {
                if (maxRight > maxLeft)
                {
                    left++;

                    if (height[left] < maxLeft)
                    {
                        water += maxLeft - height[left];
                    }
                    else
                    {
                        maxLeft = height[left];
                    }

                }
                else
                {
                    right--;
                    if (height[right] < maxRight)
                    {
                        water += maxRight - height[right];
                    }
                    else
                    {
                        maxRight = height[right];
                    }
                }
            }

            return water;

        }
    }
}
