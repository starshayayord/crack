using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вторая строка сгенерирована из первой перемешиванием и добавлением одного символа. вернуть добавленный. (a-z)
    public class Task389
    {
        public static char FindTheDifference_Arr(string s, string t)
        {
            int[] source = new int[26];
            for (int i = 0; i < t.Length; i++)
            {
                if (i < s.Length)
                {
                    source[s[i] - 'a']++;
                }
                source[t[i] - 'a']--;
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != 0)
                {
                    return (char) ('a' + i);
                }
            }

            return ' ';
        }
        public static char FindTheDifference_Dict(string s, string t)
        {
            var d = new Dictionary<char, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (i < s.Length)
                {
                    if (d.ContainsKey(s[i]))
                    {
                        d[s[i]]++;
                    }
                    else
                    {
                        d[s[i]] = 1;
                    }
                }
                if (d.ContainsKey(t[i]))
                {
                    d[t[i]]--;
                }
                else
                {
                    d[t[i]] = -1;
                }
            }

            foreach (var (k,v) in d)
            {
                if (v != 0)
                {
                    return k;
                }
            }
            return ' ';
        }
    }
}
