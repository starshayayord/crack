using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Сколько раз можно составить balloon используя символы максимум 1 раз.
    // В строке только маленькие буквы английского алфавита
    public class Task1189
    {
        public static int MaxNumberOfBalloons(string text)
        {
            int[] l = new int [26];
            for (int i = 0; i < text.Length; i++)
            {
                l[text[i] - 'a']++;
            }

            int m = l[0];
            m = Math.Min(m, l[1]);
            m = Math.Min(m, l[11]/2);
            m = Math.Min(m, l[14]/2);
            m = Math.Min(m, l[13]);
            return m;
        }
        public static int MaxNumberOfBalloons_Hash(string text)
        {
            Dictionary<char, int> map = new Dictionary<char, int>
            {
                {'b', 0},
                {'a', 0},
                {'l', 0},
                {'o', 0},
                {'n', 0}
            };
            for (int i = 0; i < text.Length; i++)
            {
                if (map.ContainsKey(text[i]))
                {
                    map[text[i]]++;
                }
            }

            int min = map['b'];
            foreach (var (k,v) in map)
            {
                min = Math.Min(min, (k == 'o' || k == 'l') ? v / 2 : v);
            }

            return min;
        }
    }
}
