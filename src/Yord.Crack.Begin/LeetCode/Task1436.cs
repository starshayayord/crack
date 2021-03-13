using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1436
    {
        public static string DestCity(IList<IList<string>> paths)
        {
            Dictionary<string, string> map = paths.ToDictionary(p => p[0], p => p.Last());
            string r = paths[0].Last();
            while (map.TryGetValue(r, out var p))
            {
                r = p;
            }
            return r;
        }
    }
}
