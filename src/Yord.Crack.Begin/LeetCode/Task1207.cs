using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Вернуть true, только если кол-во появлений каждого номера в массиве - это уникальное число
    public class Task1207
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                {
                    map[arr[i]]++;
                }
                else
                {
                    map[arr[i]] = 1;
                }
            }

            HashSet<int> s = new HashSet<int>();
            foreach (var v in map.Values)
            {
                if (s.Contains(v))
                {
                    return false;
                }

                s.Add(v);
            }

            return true;
        }
    }
}
