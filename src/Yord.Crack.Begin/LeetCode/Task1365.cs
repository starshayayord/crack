using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Вернуть количество чисел, которые меньше, чем текущее
    // [8,1,1,4] => [3,0,0,2]
    public class Task1365
    {
        public static int[] SmallerNumbersThanCurrent(int[] nums) {
            int[] a = new int[102];
            foreach(int n in nums)
            {
                //значит у следующего числа +1 число, которое меньше его
                a[n+1]++;
            }
            for(var i = 1; i < a.Length; i++)
            {
                // чисел, которых меньше его столько - сколько уже насчитано+сколько предыдущих
                a[i] += a[i-1];
            }
            
            for(int i = 0; i < nums.Length; i++)
            {
                // чисел меньше текущего столько, сколько насчитали для него циклом выше
                nums[i] = a[nums[i]];
            }
            return nums;
        }
        
        public static int[] SmallerNumbersThanCurrent_Dictionary(int[] nums)
        {
            int[] s = new int[nums.Length];
            Array.Copy(nums, s, nums.Length);
            Array.Sort(s);
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    map[s[i]] = i;
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = map[nums[i]];
            }

            return nums;
        }
    }
}
