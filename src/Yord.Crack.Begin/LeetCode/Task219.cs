using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // Есть ли два различных индекса i,j, что значения по ним равны и abs(i - j) <= k
    public class Task219
    {
        public static bool ContainsNearbyDuplicate_Window(int[] nums, int k)
        {
            var map = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > k)
                {
                    map.Remove(nums[i - k - 1]);
                }

                if (map.Contains(nums[i]))
                {
                    return true;
                }

                map.Add(nums[i]);
            }

            return false;
        }
        
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(nums[i], out var lastIdx))
                {
                    if (i - lastIdx <= k)
                    {
                        return true;
                    }
                }

                map[nums[i]] = i;
            }

            return false;
        }
    }
}
