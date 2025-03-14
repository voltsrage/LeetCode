using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ContainerWithWater
    {
        public int Execute(int[] height)
        {
            var maxArea = 0;

            var l = 0;
            var r = height.Length - 1;

            while (l < r)
            {
                var currentArea = (r - l) * Math.Min(height[r], height[l]);
                maxArea = Math.Max(maxArea, currentArea);

                if (height[l] < height[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return maxArea;
        }
    }
}
