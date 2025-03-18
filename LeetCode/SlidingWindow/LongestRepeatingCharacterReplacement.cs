using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SlidingWindow
{
    public class LongestRepeatingCharacterReplacement
    {
        /// <summary>
        /// The logic is to use a sliding window approach. We will use two pointers, left and right.
        /// We will use a dictionary to store the characters and their count.
        /// We will iterate through the string and add the character to the dictionary.
        /// If the length of the substring - max count of the character > k, we will remove the character at the left pointer
        /// and increment the left pointer.
        /// We will calculate the max length and increment the right pointer.
        /// We will return the max length.
        /// Time complexity: O(n) where n is the length of the string
        /// Space complexity: O(1) since the dictionary will have at most 26 characters
        /// </summary>
        /// <param name="s"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int Execute(string s, int k)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            // Initialize left and right pointers to 0
            int left = 0;
            int right = 0;

            // Initialize max length to 0
            int maxLength = 0;

            // Initialize dictionary to store the characters and their count
            Dictionary<char, int> characterCountMap = new Dictionary<char, int>();

            while (right < s.Length)
            {
                // Add the character to the dictionary
                if (!characterCountMap.ContainsKey(s[right]))
                {
                    characterCountMap[s[right]] = 0;
                }

                characterCountMap[s[right]]++;

                // Calculate the max count of the character
                int maxCount = characterCountMap.Values.Max();

                // If the length of the substring - max count > k, remove the character at the left pointer
                // and increment the left pointer
                if (right - left + 1 - maxCount > k)
                {
                    characterCountMap[s[left]]--;
                    left++;
                }

                // Calculate the max length
                maxLength = Math.Max(maxLength, right - left + 1);
                right++;
            }

            return maxLength;
        }
    }
}
