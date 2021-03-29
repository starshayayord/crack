using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть числа общие для двух массивов
    public class Task1316
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            HashSet<int> r = new HashSet<int>();
            int i = 0;
            int j = 0;
            while (i < nums1.Length && j < nums2.Length)
            {
                if (nums1[i] > nums2[j])
                {
                    j++;
                }
                else
                {
                    if (nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    else
                    {
                        r.Add(nums1[i]);
                        i++;
                        j++;
                    }
                }
            }
            return r.ToArray();
        }

        public static int[] Intersection_Set(int[] nums1, int[] nums2)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                s.Add(nums1[i]);
            }
            HashSet<int> r = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (s.Contains(nums2[i]))
                {
                    r.Add(nums2[i]);
                }
            }

            return r.ToArray();
        }
    }
}
