using System;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //кол-во элементов в arr1 для которых нет ни одного такого, что |arr1[i]-arr2[j]| <= d,
    //-10^3 <= arr1[i], arr2[j] <= 10^3
    public class Task1385
    {
        public static int FindTheDistanceValue2(int[] arr1, int[] arr2, int d)
        {
            Array.Sort(arr2);
            return arr1.Count(a1 => IsValid(arr2, a1, d));
        }

        private static bool IsValid(int[] arr, int v, int d)
        {
            var l = 0;
            var r = arr.Length -1;
            while (l <= r)
            {
                var mid = (l + r) / 2;
                if (Math.Abs(arr[mid] - v) <= d)
                {
                    return false;
                }

                if (arr[mid] > v)
                {
                    r = mid-1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return true;
        }

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
