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
            var answerArray = new int[2];

            var remainderDict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                var remainder = target - nums[i];

                if (remainderDict.ContainsKey(remainder))
                {
                    answerArray[0] = remainderDict[remainder];
                    answerArray[1] = i;

                    return answerArray;
                }

                remainderDict.Add(nums[i], i);
            }

            return answerArray;
        }
    }
}
