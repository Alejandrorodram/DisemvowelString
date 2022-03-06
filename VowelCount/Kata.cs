using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DisemvowelTrolls
{
    internal class Kata
    {
        public static string Disemvowel1(string str)
        {
            string[] vowels = { "a", "e", "i", "o", "u", "A", "E", "I", "O", "U" };
            for (int i = 0; i < vowels.Length; i++)
            {
                str = str.Replace(vowels[i], "");
            }
            return str;
        }

        public static string Disemvowel2(string str)
        {
            return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
        }

        public static string Disemvowel3(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
