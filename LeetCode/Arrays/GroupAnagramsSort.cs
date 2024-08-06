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
            var anagramDict = new Dictionary<string, List<string>>();

            for (var j = 0; j < strs.Length; j++)
            {
                var sortStr = new string(strs[j].OrderBy(c => c).ToArray());

                if (!anagramDict.ContainsKey(sortStr))
                {
                    anagramDict[sortStr] = new List<string>();
                }

                anagramDict[sortStr].Add(strs[j]);
            }

            return anagramDict.Values.ToList<IList<string>>();
        }
       
    }
}
