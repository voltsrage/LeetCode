using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class IsAnagram
    {
        /// <summary>
        /// The logic is to check if two strings are anagrams of each other
        /// An anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once
        /// We will use an array to store the frequency difference of characters
        /// We will iterate through both strings simultaneously
        /// We will increment the count for the character from string s
        /// We will decrement the count for the character from string t
        /// If all counts in the result array are zero, the strings are anagrams
        /// The time complexity is O(n), where n is the length of the strings
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns></returns>
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
