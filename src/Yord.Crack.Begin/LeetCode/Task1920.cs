using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1920
    {
        public static int[] BuildArray(int[] nums)
        {
            return nums.Select(n => nums[n]).ToArray();
        }
    }
}
