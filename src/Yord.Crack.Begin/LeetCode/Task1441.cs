using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //Читаем числа от 1 до N, получаем массив target с помощью стека
    //1 <= target.length <= 100
    //1 <= target[i] <= n
    //1 <= n <= 100
    public class Task1441
    {
        public static IList<string> BuildArray(int[] target, int n)
        {
            var ti = 0;
            var r = new List<string>();
            for (var i = 1; i <= n && ti < target.Length; i++)
            {
                r.Add("Push");
                if (target[ti] == i)
                {
                    ti++;
                }
                else
                {
                    r.Add("Pop");
                }
            }

            return r;
        }
    }
}
