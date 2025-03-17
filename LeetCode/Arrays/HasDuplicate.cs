using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class HasDuplicate
    {
        /// <summary>
        /// The logic behind this solution is to use a HashSet to store unique numbers
        /// We will iterate through the array and check if the current number is already in the HashSet
        /// If it is, we've found a duplicate, so we return true
        /// If not, we add the number to the HashSet
        /// If we've gone through the entire array without finding a duplicate, we return false
        /// The time complexity is O(n), where n is the length of the input array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool Execute(int[] nums)
        {
            // Create a HashSet to store unique numbers
            var duplicateChecker = new HashSet<int>();

            // Iterate through the array
            for (var i = 0; i < nums.Length; i++)
            {
                // Check if the current number is already in the HashSet
                if (duplicateChecker.Contains(nums[i]))
                {
                    // If it is, we've found a duplicate, so return true
                    return true;
                }
                // If not, add the number to the HashSet
                duplicateChecker.Add(nums[i]);
            }

            // If we've gone through the entire array without finding a duplicate, return false
            return false;
        }
    }
}
