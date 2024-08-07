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
                resultStr.Append($"{strLength.ToString()}{delimiter}{str}");
            }
            // 4#same5#pound
            return resultStr.ToString();
        }

        // Decodes a single string to a list of strings.
        public static IList<string> Decode(string s)
        {
            if (string.IsNullOrEmpty(s)) return new List<string>();

            var result = new List<string>();

            // main iterator
            var i = 0;

            while (i < s.Length)
            {

                var (strLength, j) = GetStringLength(s, i);

                var (word, k) = ConstructWord(s, j + 1, strLength);

                result.Add(word);

                i = k;
            }

            return result;
        }

        private static (int, int) GetStringLength(string str, int currentIndex)
        {
            var result = 0;

            var delimiter = "#";

            int j = currentIndex;

            while (str[j].ToString() != delimiter)
            {
                result = result * 10 + Int32.Parse(str[j].ToString());

                j++;
            }

            return (result, j);
        }

        private static (string, int) ConstructWord(string s, int k, int length)
        {
            var resultStr = new StringBuilder();

            while (length > 0)
            {
                resultStr.Append(s[k].ToString());
                k++;
                length--;
            }

            return (resultStr.ToString(), k);
        }
    }
}
