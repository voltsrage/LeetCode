using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class ProductExceptSelf
    {
        /// <summary>
        /// The logic is to calculate the product of all elements in the array except the current element
        /// We will use two passes to calculate the prefix and postfix products
        /// We will initialize the results array with the same length as the input array
        /// We will initialize the prefix product as 1
        /// We will iterate through the input array and calculate the prefix products
        /// We will store the current prefix product in the results array
        /// We will update the prefix product for the next iteration
        /// We will initialize the postfix product as 1
        /// We will iterate through the input array in reverse and calculate the postfix products
        /// We will multiply the current result (prefix product) by the postfix product
        /// We will update the postfix product for the next iteration
        /// We will return the final results array
        /// The time complexity is O(n), where n is the length of the input array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] Execute(int[] nums)
        {
            // Initialize the results array with the same length as the input array
            var results = new int[nums.Length];

            // Initialize prefix product as 1
            var prefix = 1;

            // First pass: calculate prefix products
            for (var i = 0; i < nums.Length; i++)
            {
                // Store the current prefix product in results
                results[i] = prefix;
                // Update prefix product for the next iteration
                prefix = prefix * nums[i];
            }

            // Initialize postfix product as 1
            var postfix = 1;

            // Second pass: calculate postfix products and combine with prefix products
            for (var j = nums.Length - 1; j >= 0; j--)
            {
                // Multiply the current result (prefix product) by the postfix product
                results[j] = results[j] * postfix;
                // Update postfix product for the next iteration
                postfix = postfix * nums[j];
            }

            // Return the final results array
            return results;
        }
    }
}
