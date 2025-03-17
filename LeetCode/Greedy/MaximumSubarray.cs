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
        /// The logic is to loop through the array and keep track of the currentSum and maxSum
        /// The currentSum is the sum of the current element and the currentSum
        /// The maxSum is the maximum of the currentSum and the maxSum
        /// The maxSum is the maximum sum of the subarray
        /// The time complexity is O(n) where n is the number of elements in the array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Execute(int[] nums)
        {
            // Initialize the maxSum and currentSum with the first element of the array
            int maxSum = nums[0];

            // Initialize the currentSum with the first element of the array
            int currentSum = nums[0];

            // Loop through the array starting from the second element
            for (int i = 1; i < nums.Length; i++)
            {
                // Check if the current element is greater than the sum of the current element and the currentSum
                // If it is greater, then the current element is the new currentSum
                // If it is not greater, then the sum of the current element and the currentSum is the new currentSum
                currentSum = Math.Max(nums[i], currentSum + nums[i]);

                // Check if the currentSum is greater than the maxSum
                // If it is greater, then the currentSum is the new maxSum
                maxSum = Math.Max(maxSum, currentSum);
            }

            // Return the maxSum
            return maxSum;
        }
    }
}
