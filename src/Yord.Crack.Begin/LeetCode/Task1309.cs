using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Строка из 0-9 и #.  a-i = 0-9,  j-z = 10# - 26#
    public class Task1309
    {
        public static string FreqAlphabets_2(string s)
        {
            List<char> r = new List<char>();
            // находится ли на i+2 позиции #? Если да, то двойной символ - иначе 0-9
            for (int i = 0; i < s.Length;)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    // s[i] - '0' - кол-во десятков, s[i + 1] - '0' - кол-во единиц.
                    // -1, т.к. символы начинаются с 0000 (unicode)
                    r.Add((char) ('a' + (s[i] - '0') * 10 + s[i + 1] - '0' - 1));
                    i += 3;
                }
                else
                {
                    //s[i] - '0' - кол-во единиц.
                    // -1, т.к. символы начинаются с 0000 ( unicode)
                    r.Add((char) ('a' + s[i] - '0' - 1));
                    i++;
                }
            }

            return new string(r.ToArray());
        }

        public static string FreqAlphabets(string s)
        {
            LinkedList<char> r = new LinkedList<char>();
            for (int i = s.Length - 1; i >= 0;)
            {
                if (s[i] == '#')
                {
                    r.AddFirst(Convert(new string(new[] {s[i - 2], s[i - 1]})));
                    i -= 3;
                }
                else
                {
                    r.AddFirst(Convert(new string(new[] {s[i]})));
                    i--;
                }
            }

            return new string(r.ToArray());
        }

        private static char Convert(string s)
        {
            return (char) ('a' + int.Parse(s) - 1);
        }
    }
}
