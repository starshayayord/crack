using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // найти в тексте first second third и вывести все third
    public class Task1078
    {
        public static string[] FindOccurrences(string text, string first, string second)
        {
            string[] s = text.Split(" ");
            List<string> r = new List<string>();
            for (int i = 0; i < s.Length - 2; i++)
            {
                if (s[i] == first && s[i + 1] == second)
                {
                    r.Add(s[i + 2]);
                }
            }

            return r.ToArray();
        }
    }
}
