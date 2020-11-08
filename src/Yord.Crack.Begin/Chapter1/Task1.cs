using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter1
{
    public class Task1
    {
        // Реализуйте алгоритм, определяющий все ли символы в строке встречаются только один раз
        //[PERFECT]
        public static bool IsUniqSymbols(string source)
        {
            var set = new HashSet<char>();
            foreach (var c in source)
            {
                if (set.Contains(c))
                {
                    return false;
                }

                set.Add(c);
            }

            return true;
        }
        
        public static bool IsUniqSymbols2(string source)
        {
            return source.ToHashSet().Count == source.Length;
        }
        
        // Если запрещено использовать другие структуры данных (ASCII)
        public static bool IsUniqSymbols3(string source)
        {
            if (source.Length > 256)
            {
                return false;
            }
            var asciiArr = new int[256];
            foreach (var c in source)
            {
                if (asciiArr[c] == 1)
                {
                    return false;
                }

                asciiArr[c] = 1;
            }

            return true;
        }
        
        //нельзя использовать допполнительные структуры данных
        //строка содержит только маленькие английские буквы
        //[PERFECT2]
        public static bool IsUniqueChars(string str)
        {
            if (str.Length > 256)
            {
                return false;
            }

            var checker = 0;
            for (var i = 0; i < str.Length; i++)
            {
                var val = str[i] - 'a'; //получили смещение относительно минимального символа. Т.е. смещение для a == 0

                if ((checker & (1 << val)) > 0) //если в val'ом разряде чекера уже стоит 1, значит символ уже присутствовал
                {
                    return false;
                }
                checker |= 1 << val;
            }

            return true;
        }
    }
}
