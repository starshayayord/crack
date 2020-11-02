using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin
{
    public static class Permutations
    {
        // Получить все возможные перестановки символов в строке (символы уникальны)
        public static string[] GetPer(string restStr, string prefix = "")
        {
            var results = new List<string>();
            GetPer(results, restStr, prefix);
            return results.ToArray();
        }

        private static void GetPer(List<string> results, string restStr, string prefix = "")
        {
            for (var i = 0; i < restStr.Length; i++)
            {
                var newPrefix = $"{prefix}{restStr[i]}";
                var newRest = restStr.Remove(i, 1);
                if (newRest.Length == 0) 
                {
                    results.Add(newPrefix);
                }
                else
                {
                    GetPer(results, newRest, newPrefix);
                }
            }
        }
    }
}
