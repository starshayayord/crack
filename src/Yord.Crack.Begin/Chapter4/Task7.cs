using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // имеется список проектов и список зависимостей, типа (A, B) - значит А зависит от B
    // вернуть правильный порядок построения проектов или null, если невозмножно
    public class Task7
    {
        public static HashSet<char> GetOrder2(char[] projects, Tuple<char, char>[] deps)
        {
            var result = new HashSet<char>();
            var map = projects.ToDictionary(p => p, p => new List<char>());
            foreach (var (p, d) in deps)
            {
                map[p].Add(d);
            }

            while (map.Any())
            {
                var next = CanBeBuild(map, result);
                if (next == null) return null;
                result.Add(next.Value);
            }

            return result;
        }

        //всегда будет какая-то нода, у которой нет соседей. иначе проект нельзя построить из-за циклических зависимостей
        public static char? CanBeBuild(Dictionary<char, List<char>> map, HashSet<char> r)
        {
            foreach (var (c, deps) in map)
            {
                if (deps.All(d => r.Contains(d)))
                {
                    map.Remove(c);
                    return c;
                }
            }

            return null;
        }
    }
}
