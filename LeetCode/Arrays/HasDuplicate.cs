using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public  class HasDuplicate
    {
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
