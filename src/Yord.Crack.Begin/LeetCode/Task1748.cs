using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть сумму уникальных 1 <= nums[i] <= 10, 1 <= nums.length <= 100
    public class Task1748
    {
        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int, bool> set = new Dictionary<int, bool>();
            int s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!set.TryGetValue(nums[i], out bool removed))
                {
                    s += nums[i];
                    set.Add(nums[i], false);
                }
                else
                {
                    if (!removed)
                    {
                        set[nums[i]] = true;
                        s -= nums[i];
                    }
                }
            }

            return s;
        }
        
        public static int SumOfUnique_Arr(int[] nums)
        {
            int[] fMap = new int[101];
            int s = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int freq = fMap[nums[i]];
                switch (freq)
                {
                   case 0: s += nums[i];
                       fMap[nums[i]]++;
                       break;
                   case 1: s -= nums[i];
                       fMap[nums[i]]++;
                       break;

                }
            }

            return s;

            return s;
        }
    }
}
