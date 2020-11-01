using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin
{
    public static class Permutations
    {
        // Получить все возможные перестановки символов в строке (символы уникальны)
        public static string[] GetPermutationsRecursion(string source)
        {
            var results = new List<string>();
            var lastChar = source[^1];
            if (source.Length == 1) return new[] {lastChar.ToString()};
            var rest = new string(source.Take(source.Length - 1).ToArray());
            var restPermutations = GetPermutationsRecursion(rest);
            foreach (var restPermutation in restPermutations)
            {
                for (var i = 0; i <= restPermutation.Length; i++)
                {
                    var result = new string(restPermutation.Take(i).Concat(new[] {lastChar})
                        .Concat(restPermutation.Skip(i))
                        .ToArray());
                    results.Add(result);
                }
            }

            return results.ToArray();
        }

    }
}
