using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть индексы элементов, которые в сумме дадут таргет (ровно 1 решение
    public class Task1
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.TryGetValue(target - nums[i], out int i2))
                {
                    return new[] {i, i2};
                }

                map[nums[i]] = i;
            }
            
            return null;
        }
    }
}
