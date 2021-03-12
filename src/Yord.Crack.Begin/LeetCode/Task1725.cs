using System;

namespace Yord.Crack.Begin.LeetCode
{
    // даны прямоугольники [ширина, длина]. Можно резать прямоугольник в квадрат, например 
    // [4,6] можно порезать на квадрат со стороной не больше 4.
    // Пусть maxLen - длина самой большой стороны квадрата, которую можно получить среди прямоугольников 
    // Вернуть кол-во прямоугольников, из которых можно получить такие квадраты
    //
    //
    public class Task1725
    {
        public static int CountGoodRectangles(int[][] rectangles)
        {
            int maxLen = 0;
            int n = 0;
            for (int i = 0; i < rectangles.Length; i++)
            {
                int m = Math.Min(rectangles[i][0], rectangles[i][1]);
                if (m == maxLen)
                {
                    n ++;
                    continue;
                }
                if (m > maxLen)
                {
                    maxLen = m;
                    n = 1;
                }
            }
            return n;
        }
    }
}
