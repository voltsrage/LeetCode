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
            var duplicateChecker = new HashSet<int>();

            for(var i = 0; i < nums.Length; i++)
            {
                if (duplicateChecker.Contains(nums[i]))
                {
                    return true;
                }

                duplicateChecker.Add(nums[i]);
            }

            return false;
        }
    }
}
