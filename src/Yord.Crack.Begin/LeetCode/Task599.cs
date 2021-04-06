using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Найти общие для списков рестораны с наименьшими суммами индексов
    public class Task599
    {
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            var s1 = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                s1.Add(list1[i], i);
            }

            int minSum = int.MaxValue;
            var shared = new List<string>();
            for (int i = 0; i < list2.Length; i++)
            {
                if (s1.TryGetValue(list2[i], out int i1))
                {
                    var tSum = i + i1;
                    if (tSum == minSum)
                    {
                        shared.Add(list2[i]);
                    }
                    else if (tSum < minSum)
                    {
                        minSum = tSum;
                        shared = new List<string> {list2[i]};
                    }
                }
            }

            return shared.ToArray();
        }
    }
}
