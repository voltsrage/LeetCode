using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        /// <summary>
        /// The logic is to use a sliding window approach. We will use two pointers, left and right.
        /// We will use a hashset to store the characters.
        /// We will iterate through the string and check if the character is already in the hashset.
        /// If it is, we will remove the character at the left pointer and increment the left pointer.
        /// We will add the character to the hashset and calculate the max length.
        /// We will increment the right pointer.
        /// We will return the max length.
        /// Time complexity: O(n) where n is the length of the string
        /// The space complexity is O(min(n, m)), where n is the length of the string and m is the size of the character set
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int Execute(string s)
        {
            if(string.IsNullOrEmpty(s)) return 0;

            // Set left and right pointers to 0
            int left = 0;

            int right = 0;

            // Initialize max length to 0
            int maxLength = 0;

            // Create a hashset to store the characters
            HashSet<char> set = new HashSet<char>();

            foreach(char c in s)
            {
                // If the character is already in the set, remove the character at the left pointer
                // and increment the left pointer
                while (set.Contains(c))
                {
                    set.Remove(s[left]);
                    left++;
                }
                set.Add(c);
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }

            return maxLength;
        }
    }
}
 