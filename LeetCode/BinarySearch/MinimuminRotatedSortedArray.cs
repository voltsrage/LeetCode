using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{

    public class MinimumInRotatedSortedArray
    {
        /// <summary>
        /// The logic is to find the minimum element in a rotated sorted array
        /// We will use binary search to find the minimum element
        /// If the last element is greater than the first element, the array is not rotated
        /// If the middle element is greater than the right element, the minimum element is on the right side
        /// If the middle element is less than or equal to the right element, the minimum element is on the left side
        /// We will return the element at the left pointer because it will be the minimum element
        /// The time complexity is O(log n), where n is the number of elements in the array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int Execute(int[] nums)
        {
            // If the array is null or empty, return -1
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }

            // if the last element is greater than the first element, the array is not rotated
            if (nums[nums.Length - 1] > nums[0])
            {
                return nums[0];
            }

            // Set the left and right pointers
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                // Calculate the middle index
                var mid = left + (right - left) / 2;

                // If the middle element is greater than the right element, the minimum element is on the right side
                if (nums[mid] > nums[right])
                {
                    // Move the left pointer to the right of the middle element
                    left = mid + 1;
                }
                // If the middle element is less than or equal to the right element, the minimum element is on the left side
                else
                {
                    // Move the right pointer to the middle element
                    right = mid;
                }
            }

            // Return the element at the left pointer because it will be the minimum element
            return nums[left];
        }
    }
}
