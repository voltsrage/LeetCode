using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class IsPalindrome
    {
        /// <summary>
        /// The logic behind this solution is to use two pointers to compare characters from the left and right of the string
        /// We will skip non-alphanumeric characters and compare the characters
        /// If the characters are not equal, we return false
        /// If we reach the middle of the string without finding any unequal characters, we return true
        /// The time complexity is O(n), where n is the length of the string
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Execute(string s)
        {
            if(s.Length == 0) return true;

            var left = 0;
            var right = s.Length - 1;

            while(left < right)
            {
                var leftChar = s[left];
                var rightChar = s[right];

                // Skip non-alphanumeric characters on the left while ensure the left and right pointers do not cross
                while(!char.IsLetterOrDigit(leftChar) && left < right)
                {
                    left++;
                    leftChar = s[left];
                }

                // Skip non-alphanumeric characters on the right while ensure the left and right pointers do not cross
                while(!char.IsLetterOrDigit(rightChar) && left < right)
                {
                    right--;
                    rightChar = s[right];
                }

                // Compare the characters
                if(char.ToLower(leftChar) != char.ToLower(rightChar))
                {
                    return false;
                }

                left++;
                right--;
            }

            return true;
        }
    }
}
