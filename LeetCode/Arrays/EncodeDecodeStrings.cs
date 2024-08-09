using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arrays
{
    public class EncodeDecodeStrings
    {
        public static string Encode(IList<string> strs)
        {
            var resultStr = new StringBuilder();
            var delimiter = "#";
            foreach (var str in strs)
            {
                var strLength = str.Length;
                // Append each string's length, followed by the delimiter, then the string itself
                resultStr.Append($"{strLength.ToString()}{delimiter}{str}");
            }
            // Example output: "4#same5#pound"
            return resultStr.ToString();
        }

        // Decodes a single string to a list of strings.
        public static IList<string> Decode(string s)
        {
            if (string.IsNullOrEmpty(s)) return new List<string>();
            var result = new List<string>();
            // Main iterator
            var i = 0;
            while (i < s.Length)
            {
                // Extract the length of the next string
                var (strLength, j) = GetStringLength(s, i);
                // Construct the word based on the extracted length
                var (word, k) = ConstructWord(s, j + 1, strLength);
                result.Add(word);
                // Move the iterator to the start of the next encoded string
                i = k;
            }
            return result;
        }

        private static (int, int) GetStringLength(string str, int currentIndex)
        {
            var result = 0;
            var delimiter = "#";
            int j = currentIndex;
            // Parse the length until the delimiter is found
            while (str[j].ToString() != delimiter)
            {
                result = result * 10 + Int32.Parse(str[j].ToString());
                j++;
            }
            // Return the parsed length and the index of the delimiter
            return (result, j);
        }

        private static (string, int) ConstructWord(string s, int k, int length)
        {
            var resultStr = new StringBuilder();
            // Construct the word by appending 'length' number of characters
            while (length > 0)
            {
                resultStr.Append(s[k].ToString());
                k++;
                length--;
            }
            // Return the constructed word and the new index
            return (resultStr.ToString(), k);
        }
    }
}
