using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть все домены, которые посетили и сколько раз
    public class Task811
    {
        public static IList<string> SubdomainVisits(string[] cpdomains)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < cpdomains.Length; i++)
            {
                string[] cp = cpdomains[i].Split(' ');
                int t = int.Parse(cp[0]);
                if (map.ContainsKey(cp[1]))
                {
                    map[cp[1]] += t;
                }
                else
                {
                    map[cp[1]] = t;
                }
                for (int j = 0; j < cp[1].Length; j++)
                {
                    if (cp[1][j] == '.')
                    {
                        string d = cp[1].Substring(j+1);
                        if (map.ContainsKey(d))
                        {
                            map[d] += t;
                        }
                        else
                        {
                            map[d] = t;
                        }
                    }
                }
            }

            string[] r = new string [map.Count];
            int k = 0;
            foreach (var (d, t) in map)
            {
                r[k++] = $"{t} {d}";
            }

            return r;
        }
    }
}
