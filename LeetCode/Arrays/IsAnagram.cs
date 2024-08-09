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
            // Check if the lengths of both strings are equal
            if (s.Length != t.Length) return false;

            // Array to store the frequency difference of characters
            var resultArray = new int[26];

            // Iterate through both strings simultaneously
            for (var i = 0; i < s.Length; i++)
            {
                // Increment count for character from string s
                resultArray[(int)s[i] - (int)'a']++;
                // Decrement count for character from string t
                resultArray[(int)t[i] - (int)'a']--;
            }

            // Check if all counts in resultArray are zero
            for (var j = 0; j < resultArray.Length; j++)
            {
                if (resultArray[j] != 0)
                {
                    // If any count is non-zero, strings are not anagrams
                    return false;
                }
            }

            // If all counts are zero, strings are anagrams
            return true;
        }
    }
}
