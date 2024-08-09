using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class ProductExceptSelf
    {
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
