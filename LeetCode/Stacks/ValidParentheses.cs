using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Stacks
{
    public class ValidParentheses
    {
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
