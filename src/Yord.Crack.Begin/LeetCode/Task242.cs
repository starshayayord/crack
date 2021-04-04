using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Вернуть, являяется ли t анаграммой s (a-z)
    public class Task242
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            int[] source = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                source[s[i] - 'a']++;
                source[t[i] - 'a']--;
            }

            return source.All(c => c == 0);
        }
        
        public static bool IsAnagram_DiffChars(string s, string t)
        {
            if (s.Length != t.Length) return false;
            var d = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]]++;
                }
                else
                {
                    d[s[i]] = 1;
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

            return d.Values.All(c => c == 0);
        }
    }
}
