using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.TwoPointers
{
    public class IsPalindrome
    {
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
