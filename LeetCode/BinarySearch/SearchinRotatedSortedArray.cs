using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.BinarySearch
{
    public class SearchInRotatedSortedArray
    {
        /// <summary>
        /// The logic is to search for a target element in a rotated sorted array
        /// We will use binary search to find the target element
        /// If the left element is less than or equal to the middle element, the left side is sorted
        /// If the target is between the left and middle elements, search the left side
        /// Otherwise, search the right side
        /// If the left side is not sorted, the right side must be sorted
        /// If the target is between the middle and right elements, search the right side
        /// Otherwise, search the left side
        /// The time complexity is O(log n), where n is the number of elements in the array
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int Execute(int[] array, int target)
        { 
            if(array == null || array.Length == 0)
            {
                return -1;
            }

            // Set the left and right pointers
            var left = 0;
            var right = array.Length - 1;

            while (left <= right)
            {
                // Calculate the middle index
                var mid = left + (right - left) / 2;

                // If the middle element is the target, return the index
                if (array[mid] == target)
                {
                    return mid;
                }

                // If the left element is less than or equal to the middle element, the left side is sorted
                if (array[left] <= array[mid])
                {

                    // If the target is between the left and middle elements, search the left side
                    if (array[left] <= target && target < array[mid])
                    {
                        right = mid - 1;
                    }

                    // Otherwise, search the right side
                    else
                    {
                        left = mid + 1;
                    }
                }

                // If the left side is not sorted, the right side must be sorted
                else
                {
                    // If the target is between the middle and right elements, search the right side
                    if (array[mid] < target && target <= array[right])
                    {
                        left = mid + 1;
                    }
                    // Otherwise, search the left side
                    else
                    {
                        right = mid - 1;
                    }
                }
            }
            return -1;
        }
    }
}
