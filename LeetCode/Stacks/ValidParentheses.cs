using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stacks
{
    public class ValidParentheses
    {
        /// <summary>
        /// The logic is to validate if a string of parentheses is valid
        /// We will use a stack to store the opening symbols
        /// We will use a dictionary to store the symbol pairs
        /// We will iterate through the input string
        /// If the current character is an opening symbol, we will push it onto the stack
        /// If the current character is a closing symbol, we will pop the stack and compare the symbol pairs
        /// If the stack is empty or the top of the stack doesn't match the current symbol, we will return false
        /// If the current character is neither an opening nor closing symbol, we will return false
        /// If the stack is empty, all symbols have pairs, so we will return true
        /// The time complexity is O(n), where n is the length of the input string
        /// The space complexity is O(n), where n is the length of the input string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool Execute(string input)
        {
            // If the input length is odd, it can't be valid because there will be at least one symbol without a pair
            if (input.Length % 2 != 0)
            {
                return false;
            }

            // Create a stack to store the opening symbols
            var stack = new Stack<char>();

            // Create a dictionary to store the symbol pairs
            var symbolMap = new Dictionary<char, char>
            {
                { ')','(' },
                { '}','{' },
                { ']','[' }
            };

            // Iterate through the input string
            foreach (var ch in input) 
            {
                // If the current character is an opening symbol, push it onto the stack
                if (symbolMap.ContainsValue(ch))
                {
                    stack.Push(ch);
                }
                // If the current character is a closing symbol
                else if (symbolMap.ContainsKey(ch))
                {
                    // If the stack is empty or the top of the stack doesn't match the current symbol, return false
                    if (stack.Count == 0 || stack.Pop() != symbolMap[ch])
                    {
                        return false;
                    }
                }
                // If the current character is neither an opening nor closing symbol, return false
                else
                {
                    return false;
                }
            }

            // If the stack is empty, all symbols have pairs, so return true
            return stack.Count == 0;
        }
    }
}
