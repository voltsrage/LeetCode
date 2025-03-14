using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class ThreeSumBrute
    {
        public static IList<IList<int>> Execute(int[] nums)
        {
            // Create a hashset to store the unique triplets
            var result = new List<List<int>>();
            var hashCheckSet = new HashSet<string>();

            // Loop through the array and find the triplets
            for (var i = 0; i < nums.Length -2; i++)
            {
                for(var j = i +1; j < nums.Length - 1; j++)
                {
                    for (var k = j + 1; k < nums.Length; k++)
                    {
                        var sum = nums[i] + nums[j] + nums[k];

                        // If the sum is zero, add the triplet to the hashset
                        if (sum == 0)
                        {
                            // Create a list of the triplet and sort it
                            var templist = new List<int> { nums[i], nums[j], nums[k] };
                            templist.Sort();

                            // Create a string from the sorted triplet
                            var hashCheck = string.Join(",", templist);

                            // If the triplet is already in the hashset, skip it
                            if (hashCheckSet.Contains(hashCheck))
                            {
                                continue;
                            }

                            hashCheckSet.Add(hashCheck);
                            // Add the sorted triplet to the hashset
                            result.Add(templist);
                        }
                    }
                }
            }

            return result.ToList<IList<int>>();
        }
    }
}
