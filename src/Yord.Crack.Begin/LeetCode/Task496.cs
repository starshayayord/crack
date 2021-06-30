using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task496
    {
       
        //            6  -1
        //1  4  3  2  5  6
        public static int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            var stack = new Stack<int>();
            var dict = new Dictionary<int, int>();

            foreach (var n in nums2)
            {
                //если стек не пустой и его топ меньше текущего числа
                while (stack.Count > 0 && stack.Peek() < n)
                {
                    //кладем в словарь (число, для которого пока не было большего - текущее число)
                    dict[stack.Pop()] = n;
                }

                //кладем в стек текущее
                stack.Push(n);
            }

            //для тех, для кого не нашлись большие, пушим -1
            while (stack.Count > 0)
            {
                dict[stack.Pop()] = -1;
            }

            return nums1
                .Select(x => dict[x])
                .ToArray();

        }
        
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            var r = new int[nums1.Length];
            var elemPos = new Dictionary<int, int>();
            for (var i = 0; i < nums2.Length; i++)
            {
                elemPos.Add(nums2[i], i);
            }

            for(var i=0; i< nums1.Length; i++)
            {
                var pos = elemPos[nums1[i]];
                var e = -1;
                for (var j = pos + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        e = nums2[j];
                        break;
                    }
                }

                r[i] = e;
            }

            return r;

        }
    }
}
