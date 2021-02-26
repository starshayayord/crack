using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter8
{
    // Перестановки строки с НЕуникальными символами
    public class Task8
    {
        // вместо результирующего List можно использовать HashSet.
        // Но при большом кол-ве одинаковых символов будет производиться много лишней работы. 
        public static List<string> GetPermutations(string src)
        {
            var permutations = new List<string>();
            var symbolCount = new Dictionary<char, int>();
            foreach (var s in src)
            {
                if (symbolCount.ContainsKey(s))
                {
                    symbolCount[s]++;
                }
                else
                {
                    symbolCount[s] = 1;
                }
            }
            // дешевле будет сгенерировать вместо prefix заранее массив длины src.Length и заменять в нем элементы
            // по индексу [prefix.Length - remaining]
            GetPermutations(symbolCount, string.Empty, src.Length, permutations);
            return permutations;
        }

        private static void GetPermutations(Dictionary<char, int> map, string prefix, int remaining, List<string> r)
        {
            if (remaining == 0)
            {
                r.Add(prefix);
            }
            else
            {
                // Берем первый символ (каждый раз разный, т.к. это ключи в словаре)
                var symbols = map.Keys.ToArray();
                foreach (var c in symbols)
                {
                    if (map[c] > 0)// если еще добавили не все доступные символы с этим ключом, то добавляем
                    {
                        map[c]--;
                        // Добавляем этот символ к генерируемой последовательности,
                        // уменьшаем кол-во оставших для заполнения строки и кол-во доступных символов по этому ключу.
                        // Рекурсивно вызываем функцию генерации для оставшихся в словаре символов
                        GetPermutations(map, prefix + c, remaining - 1, r);
                        // получили результат рекурсии перестановок, возвращаем символ в доступные 
                        map[c]++;
                    }
                }
            }
        }
    }
}
