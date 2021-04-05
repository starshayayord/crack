using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть индекс первого уникального символа (маленькие английский буквы)
    public class Task387
    {
        public static int FirstUniqChar_Arr(string s)
        {
            var f = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                f[s[i] - 'a']++;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (f[s[i] - 'a'] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FirstUniqChar_Pointer(string s)
        {
            int u = 0;
            int i = 0;
            var nonUnique = new int[26];
            while (i < s.Length)
            {
                nonUnique[s[i] - 'a']++;
                while (u < s.Length && nonUnique[s[u] - 'a'] > 1)
                {
                    u++;
                }

                if (u == s.Length)
                {
                    return -1;
                }

                i++;
            }

            return u;
        }
    }
}
