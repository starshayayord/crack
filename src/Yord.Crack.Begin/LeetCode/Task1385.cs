using System;

namespace Yord.Crack.Begin.LeetCode
{
    //кол-во элементов в arr1 для которых нет ни одного такого, что |arr1[i]-arr2[j]| <= d,
    //-10^3 <= arr1[i], arr2[j] <= 10^3
    public class Task1385
    {
        public static int FindTheDistanceValue(int[] arr1, int[] arr2, int d)
        {
            var f2 = new int[2 * 1000 + 1];

            foreach (var a2 in arr2)
            {
                f2[a2 + 1000]++;
            }

            var r = 0;
            foreach (var a1 in arr1)
            {
                var idx = Math.Max(a1 + 1000 - d, 0);
                var max = Math.Min(a1 + 1000 + d, 2000);
                var exists = false;
                for (; idx <= max; idx++)
                {
                    if (f2[idx] > 0)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    r++;
                }
            }

            return r;
        }
    }
}
