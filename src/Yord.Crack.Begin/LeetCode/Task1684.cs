using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Сколько строчек состоит только из разрешенных символом (только маленькие буквы из латинницы)
    public class Task1684
    {
        public static int CountConsistentStrings_Set(string allowed, string[] words)
        {
            HashSet<char> set = new HashSet<char>(allowed);
            int c = words.Length;
            foreach (var word in words)
            {
                if (word.Any(w => !set.Contains(w)))
                {
                    c--;
                }
            }

            return c;
        }
        
        public static int CountConsistentStrings_Array(string allowed, string[] words)
        {
            bool[] a = new bool[123];
            foreach (var c in allowed)
            {
                a[c] = true;
            }

            int r = words.Length;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Any(c => !a[c]))
                {
                    r--;
                }
            }

            return r;
        }
        
    }
}
