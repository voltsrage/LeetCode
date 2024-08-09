using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class GroupAnagramsSort
    {
        public static IList<IList<string>> Execute(string[] strs)
        {
            // Dictionary to store anagrams, where the key is the sorted string
            var anagramDict = new Dictionary<string, List<string>>();

            for (var j = 0; j < strs.Length; j++)
            {
                // Sort the characters of the current string alphabetically
                var sortStr = new string(strs[j].OrderBy(c => c).ToArray());

                // If the sorted string is not in the dictionary, add it with a new list
                if (!anagramDict.ContainsKey(sortStr))
                {
                    anagramDict[sortStr] = new List<string>();
                }

                // Add the original string to the list of anagrams for this sorted string
                anagramDict[sortStr].Add(strs[j]);
            }

            // Return all the lists of anagrams
            return anagramDict.Values.ToList<IList<string>>();
        }

    }
}
