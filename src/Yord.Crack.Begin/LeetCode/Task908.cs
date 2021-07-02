using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task908
    {
        public static int SmallestRangeI(int[] nums, int k)
        {
            var min = 10000;
            var max = 0;
            foreach (var num in nums)
            {
                max = Math.Max(num, max);
                min = Math.Min(num, min);
            }

            min += k;
            max -= k;
            return max > min ? max - min : 0;
        }
    }
}
