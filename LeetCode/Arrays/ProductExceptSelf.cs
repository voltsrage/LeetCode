using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class ProductExceptSelf
    {
        public static int[] Execute(int[] nums)
        {
            var results = new int[nums.Length];

            var prefix = 1;

            for (var i = 0; i < nums.Length; i++)
            {
                results[i] = prefix;
                prefix = prefix * nums[i];
            }

            var postfix = 1;
            for (var j = nums.Length - 1; j >= 0; j--)
            {
                results[j] = results[j] * postfix;
                postfix = postfix * nums[j];
            }

            return results;
        }
    }
}
