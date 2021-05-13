using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //  можно только реверсить порядок подмассива из array. вернуть, можно ли получить target из array
    //1 <= arr[i] <= 1000
    public class Task1460
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            var freq = new int [1001];
            for (var i = 0; i < target.Length; i++)
            {
                freq[target[i]]++;
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (--freq[arr[i]] < 0)
                {
                    return false;
                }
            }

            return freq.All(e => e == 0);
        }
        
        public bool CanBeEqualMap(int[] target, int[] arr)
        {
            var map = new Dictionary<int, int>();
            for (var i = 0; i < target.Length; i++)
            {
                if (map.ContainsKey(target[i]))
                {
                    map[target[i]]++;
                }
                else
                {
                    map.Add(target[i], 1);
                }
                
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (!map.ContainsKey(arr[i]) || --map[arr[i]] < 0)
                {
                    return false;
                }
            }

            return map.Values.All(e => e == 0);
        }
    }
}
