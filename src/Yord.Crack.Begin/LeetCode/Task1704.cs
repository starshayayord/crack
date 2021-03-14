using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Вернуть, похожи ли половинки строки.
    // Похожи, если кол-во 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' - одинаково
    // Длина строки - четная
    public class Task1704
    {
        public static bool HalvesAreAlike(string s)
        {
            HashSet<char> map = new HashSet<char> {'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'};
            int v = 0;
            int h = s.Length / 2;
            for (int i = 0, j = s.Length-1 ; i < h; i++, j--)
            {
                if (map.Contains(s[i]))
                {
                    v++;
                }
                
                if (map.Contains(s[j]))
                {
                    v--;
                }
            }

            return v == 0;
        }
    }
}
