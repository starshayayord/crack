using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1266
    {
        // N точек с координатами [x,y]. Вернуть мин время чтобы пройти все точки.
        // За секунду можно сделать что либо одно
        // * пройти вертикально или горизонтально 1 клетку
        // * пройти по диагонали 1 клетку.
        // Порядок должен остаться. Если пройти точку в неправильно порядке, то визит не засчитывается
        //
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int sec = 0;
            for (int i = 1; i < points.Length; i++)
            {
                sec += Math.Max(Math.Abs(points[i - 1][0] - points[i][0]), Math.Abs(points[i - 1][1] - points[i][1]));
            }

            return sec;
        }
    }
}
