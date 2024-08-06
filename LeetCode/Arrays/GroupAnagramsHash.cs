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
                var anagramArr = GetAnagramArray(strs[j]);

                var key = string.Join(",", anagramArr);

                if (!anagramDict.ContainsKey(key))
                {
                    anagramDict[key] = new List<string>();
                }

                anagramDict[key].Add(strs[j]);
            }

            return anagramDict.Values.ToList<IList<string>>();
        }

        public static int[] GetAnagramArray(string str)
        {
            var result = new int[26];

            for (var i = 0; i < str.Length; i++)
            {
                result[(int)str[i] - 97]++;
            }

            return result;
        }
    }
}
