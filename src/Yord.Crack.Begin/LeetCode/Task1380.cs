using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть числа, которые являются минимальными в строке, но макстимальными в столбце
    //1 <= matrix[i][j] <= 10^5, все числа уникальные
    public class Task1380
    {
        // на самом деле единственным счастливым номером мб:
        // максимальный из минимумов по сторокам, который равень минимальному из максимумов по столбцам
        //(Допустим X не униален, тогда W - дополнительной счастливый номер
        //W             x - y 
        //x + y1         x               x + y2
        //x - y3

        //W < x-y, т.к. он минимальный в строке
        //W> x+y1, т.к. он максимальный в столбце
        //x+y1 < x-y, но y, y1 >0, значит это невозможно

        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;

            int maxMin = int.MinValue;
            for (int i = 0; i < m; i++)
            {
                int min = int.MaxValue;
                for (int j = 0; j < n; j++)
                {
                    min = Math.Min(min, matrix[i][j]);
                }

                maxMin = Math.Max(maxMin, min);
            }

            int minMax = int.MaxValue;
            for (int j = 0; j < n; j++)
            {
                int max = int.MinValue;
                for (int i = 0; i < m; i++)
                {
                    max = Math.Max(max, matrix[i][j]);
                }

                minMax = Math.Min(minMax, max);
                if (minMax < maxMin)
                {
                    return Array.Empty<int>();
                }
            }


            return maxMin == minMax ? new[] {maxMin} : Array.Empty<int>();
        }
    }
}
