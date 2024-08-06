using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class IsAnagram
    {
        public static bool Execute(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var resultArray = new int[26];

            for (var i = 0; i < s.Length; i++)
            {
                resultArray[(int)s[i] - (int)'a']++;
                resultArray[(int)t[i] - (int)'a']--;
            }

            for (var j = 0; j < resultArray.Length; j++)
            {
                if (resultArray[j] != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
