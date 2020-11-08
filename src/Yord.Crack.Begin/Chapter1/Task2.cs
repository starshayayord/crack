using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter1
{
    //для двух строк напишите метод, который определяет, является ли одна строка перестановкой другой
    public class Task2
    {
        //[PERFECT] N, more memory
        public static bool IsPermutation(string source, string toCheck)
        {
            if (source.Length != toCheck.Length)
            {
                return false;
            }

            var map = new Dictionary<char, int>();
            foreach (var c in source)
            {
                if (map.TryGetValue(c, out _))
                {
                    map[c] += 1;
                }
                else
                {
                    map[c] = 1;
                }
            }

            foreach (var c in toCheck)
            {
                if (!map.TryGetValue(c, out var count) || count == 0)
                {
                    return false;
                }

                map[c] -= 1;
            }

            return true;
        }

        //[PERFECT] Nlog(N), less memory
        public static bool IsPermutation2(string source, string toCheck)
        {
            
            if (source.Length != toCheck.Length)
            {
                return false;
            }
            

            Array.Sort(source.ToCharArray());
            Array.Sort(toCheck.ToCharArray());
            
            return source.Equals(toCheck);
        }
    }
}
