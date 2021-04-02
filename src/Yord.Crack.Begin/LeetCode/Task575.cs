using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // candyType[i] - тип конфет. Сколько типов можно съесть, если есть можно не более n/2 каждого типа (n - четное)
    public class Task575
    {
        public static int DistributeCandies(int[] candyType)
        {
            var max = candyType.Length / 2;
            var r = int.MaxValue;
            var s = new HashSet<int>();
            for (int i = 0; i < candyType.Length; i++)
            {
                if (!s.Contains(candyType[i]))
                {
                    s.Add(candyType[i]);
                    r = Math.Min(max, s.Count);
                    if (r == max)
                    {
                        break;
                    }
                }
            }

            return r;
        }
    }
}
