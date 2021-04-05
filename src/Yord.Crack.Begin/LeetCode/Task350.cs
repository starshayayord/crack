using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть пересечение массивов, учитывая кол-во повторяющихся элементов
    //0 <= nums1[i], nums2[i] <= 1000, 1 <= nums1.length, nums2.length <= 1000
    public class Task350
    {
        public static int[] Intersect_Sort(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            int i1 = 0;
            int i2 = 0;
            var r = new List<int>();
            while (i1 < nums1.Length && i2 < nums2.Length)
            {
                if (nums1[i1] == nums2[i2])
                {
                    r.Add(nums1[i1]);
                    i1++;
                    i2++;
                }
                else
                {
                    if (nums1[i1] > nums2[i2])
                    {
                        i2++;
                    }
                    else
                    {
                        i1++;
                    }
                }
            }

            return r.ToArray();
        }

        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            var s1 = new int[1001];
            for (int i = 0; i < nums1.Length; i++)
            {
                s1[nums1[i]]++;
            }

            var r = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (s1[nums2[i]] > 0)
                {
                    r.Add(nums2[i]);
                }
            }

            return r.ToArray();
        }
    }
}
