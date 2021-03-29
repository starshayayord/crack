using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // все элементы в массиве повторяются дважды и только 1 - единожды. Вернуть уникальный
    public class Task136
    {
        public static int SingleNumber(int[] nums)
        {
            // 0 ^ N = N
            // N ^ N = 0
            int r = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                r ^= nums[i];
            }

            return r;
        }
        public static int SingleNumber_HashTable(int[] nums)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i=0; i<nums.Length; i++)
            {
                if (!s.Contains(nums[i]))
                {
                    s.Add(nums[i]);
                }
                else
                {
                    s.Remove(nums[i]);
                }
            }

            return s.First();
        }
    }
}
