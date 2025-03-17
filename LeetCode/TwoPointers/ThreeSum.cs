using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ThreeSum
    {
        /// <summary>
        /// The logic is to find all unique triplets in the array that sum up to zero
        /// We will sort the array
        /// We will iterate through the array
        /// We will use two pointers to find the other two numbers that sum up to the negative of the current number
        /// We will skip duplicates
        /// The time complexity is O(n^2), where n is the number of elements in the array
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<IList<int>> Execute(int[] nums)
        {
            var result = new List<IList<int>>();

            var sortedNums = nums.OrderBy(x => x).ToArray();

            for (var i = 0; i < sortedNums.Length; i++)
            {
                if (i > 0 && sortedNums[i] == sortedNums[i - 1])
                {
                    continue;
                }

                var a = sortedNums[i];

                var l = i + 1;
                var r = sortedNums.Length - 1;

                while (l < r)
                {
                    var sum = a + sortedNums[l] + sortedNums[r];

                    if (sum > 0)
                    {
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        result.Add(new List<int> { a, sortedNums[l], sortedNums[r] });
                        l++;
                        while (sortedNums[l] == sortedNums[l - 1] && l < r)
                        {
                            l++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
