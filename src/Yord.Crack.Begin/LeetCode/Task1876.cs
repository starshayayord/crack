using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //кол-во строк из трех уникальных. Если есть несколько вариантов одной и той же строки, учиывать все
    public class Task1876
    {
        public static int CountGoodSubstrings2(string s)
        {
            var r = 0;
            for (var i = 2; i < s.Length; i++)
            {
                if (s[i] != s[i - 1] && s[i] != s[i - 2] && s[i - 1] != s[i - 2])
                {
                    r++;
                }
            }

            return r;
        }
        public static int CountGoodSubstrings(string s)
        {
            var hash = new HashSet<char>();
            var c = 0;
            var r = 0;
            for (var i = 0; i < s.Length; i++)
            {
               
                hash.Add(s[i]);
                c++;
                if (c != 3) continue;
                if (hash.Count == 3)
                {
                    r++;
                }

                c = 0;
                i -= 2;
                hash.Clear();
            }

            return r;
        }
    }
}
