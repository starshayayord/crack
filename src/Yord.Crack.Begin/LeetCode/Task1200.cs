using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть пары в минимальной разницей(в возрастающем порядке), числа уникальные
    public class Task1200
    {
        public static IList<IList<int>> MinimumAbsDifference(int[] arr)
        {
            var freq = new int[1000000 * 2 + 1];
            var minIdx = int.MaxValue;
            var maxIdx = int.MinValue;
            foreach (var a in arr)
            {
                var numIdx = a + 1000000;
                minIdx = Math.Min(minIdx, numIdx);
                maxIdx = Math.Max(maxIdx, numIdx);
                freq[numIdx]++;
            }

            var idx = 0;
            arr[idx] = minIdx - 1000000;
            var min = maxIdx - minIdx;
            for (var i = minIdx+1; i <= maxIdx; i++)
            {
                if (freq[i] == 0)
                {
                    continue;
                }
                var num = i - 1000000;
                var diff = num-arr[idx];
                idx++;
                arr[idx] = num;
                if (diff < min)
                {
                    min = diff;
                }
            }

            var r = new List<IList<int>>();
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] == min)
                {
                    r.Add(new[] {arr[i - 1], arr[i]});
                }
            }

            return r;
        }
        
        public static IList<IList<int>> MinimumAbsDifference3(int[] arr)
        {
            Array.Sort(arr);
            var min = int.MaxValue;
            var map = new Dictionary<int, List<IList<int>>>();
            for (var i = 1; i < arr.Length; i++)
            {
                var diff = arr[i] - arr[i - 1];
                if (diff > min)
                {
                    continue;
                }

                min = diff;
                if (map.ContainsKey(diff))
                {
                    map[diff].Add(new[] {arr[i - 1], arr[i]});
                }
                else
                {
                    map.Add(diff, new List<IList<int>> {new[] {arr[i - 1], arr[i]}});
                }
            }

            return map[min];
        }

        public static IList<IList<int>> MinimumAbsDifference2(int[] arr)
        {
            Array.Sort(arr);
            var min = int.MaxValue;

            for (var i = 1; i < arr.Length; i++)
            {
                min = Math.Min(min, arr[i] - arr[i - 1]);
            }

            var r = new List<IList<int>>();
            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] - arr[i - 1] == min)
                {
                    r.Add(new[] {arr[i - 1], arr[i]});
                }
            }

            return r;
        }
    }
}
