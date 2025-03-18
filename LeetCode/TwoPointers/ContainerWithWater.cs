using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ContainerWithWater
    {
        /// <summary>
        /// The logic is to find the maximum area that can be formed by two vertical lines and the x-axis
        /// We will use two pointers to keep track of the left and right vertical lines
        /// We will calculate the area by taking the minimum of the two vertical lines and multiplying it by the distance between the two vertical lines
        /// We will update the maximum area if the current area is greater
        /// We will move the pointer with the smaller vertical line towards the other pointer
        /// The time complexity is O(n), where n is the number of vertical lines
        /// The space complexity is O(1)
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
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
