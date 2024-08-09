using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class TwoSum
    {
        public static int[] Execute(int[] nums, int target)
        {
            // Initialize array to store the result indices
            var answerArray = new int[2];

            // Dictionary to store numbers and their indices
            var remainderDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                // Calculate the complement (remainder) needed to reach the target
                var remainder = target - nums[i];

                // If the complement exists in the dictionary, we've found a solution
                if (remainderDict.ContainsKey(remainder))
                {
                    // Set the first index to the index of the complement
                    answerArray[0] = remainderDict[remainder];
                    // Set the second index to the current index
                    answerArray[1] = i;
                    return answerArray;
                }

                // If no solution found yet, add the current number and its index to the dictionary
                remainderDict.Add(nums[i], i);
            }

            // If no solution is found, return the initialized array (which will be [0, 0])
            return answerArray;
        }
    }
}
