using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //-100 <= nums[i] <= 100. Отсортировать по возврастанию частоты.
    //Если одинаковая, то по убыванию значения
    public class Task1636
    {
        public static int[] FrequencySort2(int[] nums)
        {
            var map = new Dictionary<int, int>();
            foreach(var n in nums)
            {
                if (!map.ContainsKey(n))
                {
                    map.Add(n, 1);
                }
                else
                {
                    map[n]++;
                }
            }
        
            int index=0;
            foreach(var (num, freq) in map.OrderBy(x=>x.Value).ThenByDescending(x=>x.Key)){
                for(int i=0;i<freq;i++){
                    nums[index]=num;
                    index++;
                }
            }
            return nums;
        }
        public static int[] FrequencySort(int[] nums)
        {
            var freq = new int [201];
            var max = 0;
            foreach (var num in nums)
            {
                var idx = num + 100;
                freq[idx]++;
                max = Math.Max(max, freq[idx]);
            }

            var freqList = new List<int> [max + 1];
            for (var i = freq.Length -1; i >= 0; i--)
            {
                var f = freq[i];
                var num = i - 100;
                while (freq[i] > 0)
                {
                    if (freqList[f] == null)
                    {
                        freqList[f] = new List<int> {num};
                    }
                    else
                    {
                        freqList[f].Add(num);
                    }

                    freq[i]--;
                }
            }

            var rIdx = 0;
            for (int i = 1; i < freqList.Length; i++)
            {
                if (freqList[i] != null)
                {
                    foreach (var n in freqList[i])
                    {
                        nums[rIdx] = n;
                        rIdx++;
                    }
                }
            }

            return nums;
        }
    }
}
