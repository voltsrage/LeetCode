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
        /// Logic is to loop through the array starting from the last element
        /// Check if the current element plus the current index is greater than or equal to the goal
        /// If it is greater than or equal to the goal, then the goal is the current index
        /// If the goal is 0, then return true
        /// If the goal is not 0, then return false
        /// The time complexity is O(n) where n is the number of elements in the array
        /// The space complexity is O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static bool Execute(int[] nums)
        {
            // Set the goal to the last index of the array, since we want to reach the last index
            var goal = nums.Length - 1;

            // Loop through the array starting from the last element
            for (int i = nums.Length - 1; i >= 0; i--) 
            {
                // Check if the current element plus the current index is greater than or equal to the goal
                // If it is greater than or equal to the goal, then the goal is the current index
                if (nums[i] + i > goal)
                {
                    goal = i;
                }
            }

            // Check if the goal is 0
            return goal == 0;
        }
    }
}
