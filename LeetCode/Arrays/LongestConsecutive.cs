using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class LongestConsecutive
    {
        /// <summary>
        /// The logic behind this solution is to first turn the input array into a hash set
        /// We will then iterate through the hash set and check if the current number is the start of a new streak
        /// If it is, we will increment the current number and the streak until we reach the end of the streak
        /// We will update the max streak if the current streak is longer
        /// We will return the max streak
        /// The time complexity is O(n), where n is the length of the input array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Execute(int[] nums)
        {
            // Short-circuit if the input array is empty
            if(nums.Length == 0) return 0;

            // create variable to store the longest streak
            var maxStreak = 0;

            // Turn the input array into a hash set
            // Because it will create a unique ordered list of numbers with O(1) lookup time
            var numSet = new HashSet<int>(nums);

            foreach(var num in numSet)
            {
                // Check if the current number is the start of a new streak
                // If a lower number is found, then this will cause the program to waste iterations
                if(!numSet.Contains(num - 1))
                {
                    var currentNum = num;
                    var currentStreak = 1;

                    // Check if the next number is in the set
                    while(numSet.Contains(currentNum + 1))
                    {
                        // increment the current number and the streak
                        currentNum++;
                        currentStreak++;
                    }

                    // Update the max streak
                    maxStreak = Math.Max(maxStreak, currentStreak);
                }
            }

            return maxStreak;   
        }
    }
}
