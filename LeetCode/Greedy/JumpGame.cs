using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    public class JumpGame
    {
        /// <summary>
        /// The logic is to loop through the array and keep track of the maxIndex
        /// The maxIndex is the maximum index that can be reached
        /// The time complexity is O(n) where n is the number of elements in the array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool Execute(int[] nums)
        {
            // Initialize the maxIndex with the first element of the array
            int maxIndex = nums[0];

            // Loop through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // Check if the current index is greater than the maxIndex
                // If it is greater, then return false
                if (i > maxIndex)
                {
                    return false;
                }
                // Check if the sum of the current index and the current element is greater than the maxIndex
                // If it is greater, then the sum of the current index and the current element is the new maxIndex
                maxIndex = Math.Max(maxIndex, i + nums[i]);
            }
            // Return true
            return true;
        }
    }
}
