using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть, встричается ли хоть 1 дубликат в массива 
    public class Task217
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            var s = new HashSet<int>();
            for(int i = 0; i< nums.Length; i++)
            {
                if (s.Contains(nums[i]))
                {
                    return true;
                }

                s.Add(nums[i]);
            }

            return false;
        }
        public static bool ContainsDuplicate_Bit(int[] nums)
        {
            // пусть каждый бит - это номер. кол-во битов в номере - 32 (int). -10^9 <= nums[i] <= 10^9
            // сделаем 2 массива, для нетрицательных и отрицательных
            // например 0 /32 = 0, 0 % 32 = 0 pos[0] = 00000000000000000000000000000001;
            // 37/32 = 1, 37%32 = 5 pos[1] = 00000000000000000000000000100000
            // аналогично для отрицательных
            var pos = new int [1000000000 / 32 + 1];
            var neg = new int [1000000000 / 32 + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                var mask = 1 << nums[i] % 32;
                int idx = nums[i] / 32;
                if (nums[i] >= 0)
                {
                    if ((pos[idx] & mask) > 0)
                    {
                        return true;
                    }

                    pos[idx] |= mask;
                }
                else
                {
                    idx *= -1;
                    if ((neg[idx] & mask) == 1)
                    {
                        return true;
                    }

                    neg[idx] |= mask;
                }
            }

            return false;
        }
    }
}
