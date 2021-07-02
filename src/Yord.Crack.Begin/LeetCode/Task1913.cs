namespace Yord.Crack.Begin.LeetCode
{
    public class Task1913
    {
        //5, 6, 2, 7, 4
        public static int MaxProductDifference(int[] nums)
        {
            var min1 = 100001;
            var min2 = 100001;
            var max1 = 0;
            var max2 = 0;
            foreach (var num in nums)
            {
                if (num < min1)
                {
                    min2 = min1;
                    min1 = num;
                }
                else
                {
                    if (num < min2)
                    {
                        min2 = num;
                    }
                }

                if (num > max2)
                {
                    max1 = max2;
                    max2 = num;
                }
                else
                {
                    if (num > max1)
                    {
                        max1 = num;
                    }
                }
            }

            return max1 * max2 - min1 * min2;
        }
    }
}
