using System;

namespace Yord.Crack.Begin.LeetCode
{
    //1 <= nums.length <= 100, -100 <= nums[i] <= 100
    //найти минимум, с которого надо начинать, чтоб на каждом шаге получить число не меньше 1
    public class Task1413
    {
        public static int MinStartValue(int[] nums)
        {
            var minStep = 0;
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
                minStep = Math.Min(sum, minStep);
            }
            return 0 - minStep + 1;
        }
    }
}
