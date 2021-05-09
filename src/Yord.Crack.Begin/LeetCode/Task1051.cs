using System;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //цифры в массиве должны стоять в неубывающем порядке,1 <= heights[i] <= 100
    // вернуть кол-во чисел не на своем месте
    
    public class Task1051
    {
        public static int HeightChecker(int[] heights)
        {
            var prev = new int[heights.Length];
            Array.Copy(heights, prev, heights.Length);
            Array.Sort(heights);
            return heights.Where((t, i) => t != prev[i]).Count();
        }
        
        public static int HeightChecker2(int[] heights)
        {
            var freq = new int[101];
            for (int i = 0; i < heights.Length;i++)
            {
                freq[heights[i]]++;//сколько учеников каждого роста
            }

            int r = 0;
            int c = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                while (freq[c] == 0)
                {
                    c++;// идем до следущей ожидаемой высоты ученика
                }

                if (c != heights[i])//если следюущая ожидаемая высота не равна текущей
                {
                    r++;//значит ученик не на своем месте
                }

                freq[c]--;//этого ученика посчитали
            }

            return r;
        }
    }
}
