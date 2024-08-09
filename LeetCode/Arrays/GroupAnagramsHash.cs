using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class GroupAnagramsHash
    {
        public static IList<IList<string>> Execute(string[] strs)
        {
            var anagramDict = new Dictionary<string, List<string>>();
            for (var j = 0; j < strs.Length; j++)
            {
                // Get the character frequency array for the current string
                var anagramArr = GetAnagramArray(strs[j]);
                // Create a key by joining the frequency array elements
                var key = string.Join(",", anagramArr);

                // If the key doesn't exist in the dictionary, create a new list
                if (!anagramDict.ContainsKey(key))
                {
                    anagramDict[key] = new List<string>();
                }
                // Add the current string to the list of anagrams with the same key
                anagramDict[key].Add(strs[j]);
            }
            // Return all the lists of anagrams
            return anagramDict.Values.ToList<IList<string>>();
        }

        public static int[] GetAnagramArray(string str)
        {
            // Create an array to store the frequency of each lowercase letter
            var result = new int[26];
            for (var i = 0; i < str.Length; i++)
            {
                // Increment the count for the current character
                // 97 is the ASCII value of 'a', so we subtract it to get 0-25 index
                result[(int)str[i] - 97]++;
            }
            return result;
        }
    }
}
