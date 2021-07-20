using System;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1929
    {
        public static int[] GetConcatenation(int[] nums)
        {
            var l = nums.Length;
            var ans = new int[l * 2];
            for (var i = 0; i < l; i++)
            {
                ans[i] = nums[i];
                ans[i + l] = nums[i];
            }

            return ans;
        }

        public static int[] GetConcatenation2(int[] nums)
        {
            var l = nums.Length;
            Array.Resize(ref nums, l << 1);
            Array.Copy(nums, 0, nums, l, l);
            return nums;
        }

        public static int[] GetConcatenation3(int[] nums)
        {
            return nums.Concat(nums).ToArray();
        }
    }
}
