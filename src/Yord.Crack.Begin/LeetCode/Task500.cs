using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task500
    {
        private static Dictionary<char, int> Keyboard = new Dictionary<char, int>
        {
            {'q', 0}, {'w', 0}, {'e', 0}, {'r', 0}, {'t', 0}, {'y', 0}, {'u', 0}, {'i', 0}, {'o', 0}, {'p', 0},
        
            {'a', 1}, {'s', 1}, {'d', 1}, {'f', 1}, {'g', 1}, {'h', 1}, {'j', 1}, {'k', 1}, {'l', 1},
        
            {'z', 2}, {'x', 2}, {'c', 2}, {'v', 2}, {'b', 2}, {'n', 2}, {'m', 2}
        };
        
        public static string[] FindWords(string[] words)
        {
            List<string> r = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                var d = Keyboard[char.ToLower(words[i][0])];
                bool can = true;
                for (int j = 1; j < words[i].Length; j++)
                {
                    if (Keyboard[char.ToLower(words[i][j])] != d)
                    {
                        can = false;
                        break;
                    }
                }

                if (can)
                {
                    r.Add(words[i]);
                }
            }

            return r.ToArray();
        }
    }
}
