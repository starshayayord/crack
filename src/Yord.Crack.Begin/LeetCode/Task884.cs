using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть слова, которые появляются ровно 1 раз в одном предложении и не появляются в другом
    public class Task884
    {
        public static string[] UncommonFromSentences(string A, string B)
        {
            var map = new Dictionary<string, int>();
            //Если слово имеет частоту 1, то его и так точно не будет во втором предложении
            foreach (var w in A.Split(' '))
            {
                if (map.ContainsKey(w))
                {
                    map[w]++;
                }
                else
                {
                    map[w] = 1;
                }
            }
            
            foreach (var w in B.Split(' '))
            {
                if (map.ContainsKey(w))
                {
                    map[w]++;
                }
                else
                {
                    map[w] = 1;
                }
            }

            var r = new List<string>();
            foreach (var (k, v) in map)
            {
                if (v == 1)
                {
                    r.Add(k);
                }
            }

            return r.ToArray();
        }
    }
}
