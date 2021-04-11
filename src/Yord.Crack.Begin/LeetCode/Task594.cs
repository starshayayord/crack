using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть длину последовательности, разница между наименьшим и наибольшим элементами в которое равна 1
    // можно удалять любые элементы, но нельзя менять порядок
    public class Task594
    {
        // лучше по времени
        public static int FindLHS(int[] nums)
        {
            var d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (d.ContainsKey(nums[i]))
                {
                    d[nums[i]]++;
                }
                else
                {
                    d[nums[i]] = 1;
                }
            }

            var m = 0;
            foreach (var (k, v) in d)
            {
                // порядок не важен,т.к.
                // * если большее число(k+1) стоит правее, то длина последовательности будет для меньшего(k)
                // * если большее число(k+1) стоит левее, то длина последовательности будет для него(k+1)
                if (d.TryGetValue(k + 1, out var g))
                {
                    m = Math.Max(m, v + g);
                }
            }

            return m;
        }

        // лучше по памяти
        public static int FindLHS_Window(int[] nums)
        {
            Array.Sort(nums);
            var min = 0;
            var m = 0;
            var j = min; // j - индекс последнего элемента, равного nums[min]
            for (int i = 1; i < nums.Length;)
            {
                if (nums[i] == nums[min])
                {
                    j = i;
                    i++;
                    continue;
                }

                if (nums[i] - nums[min] == 1)
                {
                    m = Math.Max(m, i - min + 1);
                    i++;
                }
                else // diff >1
                {
                    min = j + 1;
                    j = min;
                }
            }

            return m;
        }
    }
}
