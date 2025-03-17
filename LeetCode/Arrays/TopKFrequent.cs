using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class TopKFrequent
    {
        /// <summary>
        /// The logic behind this solution is to find the k most frequent elements in an array
        /// We will use a dictionary to store the frequency of each number
        /// We will create a bucket array where the index represents frequency
        /// We will iterate through the dictionary and add each number to its corresponding frequency bucket
        /// We will iterate through the buckets from highest frequency to lowest and add the numbers to the result list
        /// We will return the k most frequent elements
        /// The time complexity is O(n), where n is the length of the input array
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
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

            // Create a bucket array where the index represents frequency
            var bucket = new List<int>[nums.Length + 1];
            foreach (var item in countDict)
            {
                int freq = item.Value;
                if (bucket[freq] == null)
                {
                    bucket[freq] = new List<int>();
                }
                // Add the number to its corresponding frequency bucket
                bucket[freq].Add(item.Key);
            }

            var result = new List<int>();
            // Iterate through buckets from highest frequency to lowest
            for (var j = bucket.Length - 1; j >= 0 && result.Count < k; j--)
            {
                if (bucket[j] != null)
                {
                    // Add all numbers from the current frequency bucket
                    result.AddRange(bucket[j]);
                }
            }

            // Return the k most frequent elements
            return result.Take(k).ToArray();
        }
    }
}
