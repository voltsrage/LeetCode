using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class TopKFrequent
    {
        public static int[] Execute(int[] nums, int k)
        {


            var countDict = new Dictionary<int, int>();

            // Count the frequency of each number
            foreach (var num in nums)
            {
                if (!countDict.ContainsKey(num))
                {
                    countDict[num] = 1;
                }
                else
                {
                    countDict[num]++;
                }
            }

            var bucket = new List<int>[nums.Length + 1];
            foreach (var item in countDict)
            {
                int freq = item.Value;
                if (bucket[freq] == null)
                {
                    bucket[freq] = new List<int>();
                }
                bucket[freq].Add(item.Key);
            }

            var result = new List<int>();
            for (var j = bucket.Length - 1; j >= 0 && result.Count < k; j--)
            {
                if (bucket[j] != null)
                {
                    result.AddRange(bucket[j]);
                }
            }

            return result.Take(k).ToArray();
        }
    }
}
