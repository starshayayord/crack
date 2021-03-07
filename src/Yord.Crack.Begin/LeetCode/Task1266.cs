using System;
using System.Linq;

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
            for (int i = 0; i < points.Length - 1; i++)
            {
                int x1 = points[i][0];
                int y1 = points[i][1];
                int x2 = points[i+1][0];
                int y2 = points[i+1][1];
                sec += Math.Max(Math.Abs(x2 - x1), Math.Abs(y2-y1));
            }

            return sec;
            
            
        }
    }
}
