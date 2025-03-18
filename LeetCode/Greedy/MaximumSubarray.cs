using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Greedy
{
    public class MaximumSubarray
    {
        /// <summary>
        /// The logic is to loop through the array and add the current element to the currentSum.
        /// If the currentSum is less than zero, then set the currentSum to zero.
        /// Get the maximum of the currentSum and the maxSum.
        /// Return the maxSum.
        /// The time complexity is O(n) and the space complexity is O(1).
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Execute(int[] nums)
        {
            // Initialize the maxSum and currentSum with the first element of the array
            int maxSum = nums[0];

            // Initialize the currentSum to equal zero
            int currentSum = 0;

            // Loop through the array starting from the second element
            for (int i = 0; i < nums.Length; i++)
            {
                if(currentSum < 0)
                {
                    currentSum = 0;
                }

                // Add the current element to the currentSum
                currentSum += nums[i];

                // Get the maximum of the currentSum and the maxSum
                maxSum = Math.Max(currentSum, maxSum);
            }

            // Return the maxSum
            return maxSum;
        }
    }
}
