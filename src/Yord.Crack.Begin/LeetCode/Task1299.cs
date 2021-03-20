using System;

namespace Yord.Crack.Begin.LeetCode
{
    //Заменить элемент на самый большой справа от него. Последний заменить на -1;1 <= arr[i] <= 100000
    public class Task1299
    {
        
        public static int[] ReplaceElements(int[] arr)
        {
            int m = -1;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int t = arr[i];
                arr[i] = m;
                m = Math.Max(t, m);
            }

            return arr;
        }
    }
}
