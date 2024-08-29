using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ThreeSum
    {
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
