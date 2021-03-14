using System;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть макисмальное значение (nums[i]-1)*(nums[j]-1), 1 <= nums[i] <= 10^3
    public class Task1464
    {
        public static int MaxProduct(int[] nums)
        {
            int l = nums.Length - 1;
            Array.Sort(nums);
            return (nums[l] - 1) * (nums[l - 1] - 1);
        }
        
        public static int MaxProduct_N(int[] nums)
        {
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > m1)
                {
                    m2 = m1;
                    m1 = nums[i];
                }
                else
                {
                    if (nums[i] > m2)
                    {
                        m2 = nums[i];
                    }
                }
            }

            return (m1 - 1) * (m2 - 1);
        }
    }
}
