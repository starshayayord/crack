using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter8
{
    // посчитать минимальную сумму пути из левого верхнего угла в правый нижний
    public class MinSum
    {
        public static int MinPathSum2(int[][] grid)
        {
            var maxRow = grid.Length;
            var maxColumn = grid[0].Length;
            // по верхней строке мы можем придти только идя вправо. считаем, сколько стоит путь вправо
            for (var i = 1; i < maxColumn; i++)
            {
                grid[0][i] = grid[0][i - 1] + grid[0][i];
            }

            for (var i = 1; i < maxRow; i++)
            {
                // по левому столбцу мы можем придти только идя вниз. считаем, сколько стоит путь вниз
                grid[i][0] = grid[i - 1][0] + grid[i][0];
                for (var j = 1; j < maxColumn; j++)
                {
                    //тогда лучший путь до каждой следующей клетки -
                    // это минимальный путь из верхней или левой + она сама
                    grid[i][j] += Math.Min(grid[i-1][j], grid[i][j-1]);
                }
            }

            return grid[maxRow - 1][maxColumn-1];

        }
        public static int MinPathSum(int[][] grid) 
        {
            //  идем из левой верхней точки (0;0) в точку справа внизу
            // каждый шаг мб только вправо (column+1) или вниз (row+1)

            var maxRow = grid.Length-1;
            var maxColumn = grid[0].Length-1;
            var queue = new Queue<Point>();
            queue.Enqueue(new Point
            {
                Row = 0,
                Column = 0,
                Sum = grid[0][0]
            });
            var min = int.MaxValue;
            while (queue.Any())
            {
                var n = queue.Dequeue();
                if (n.Row == maxColumn && n.Column == maxColumn)
                {
                    if (min > n.Sum)
                    {
                        min = n.Sum;
                    }
                    continue;
                }
                if (n.Column < maxColumn) // вправо
                {
                    queue.Enqueue(new Point
                    {
                        Row = n.Row,
                        Column = n.Column+1,
                        Sum = n.Sum + grid[n.Row][n.Column+1]
                    });
                }
                if (n.Row < maxRow) // вниз
                {
                    queue.Enqueue(new Point
                    {
                        Row = n.Row+1,
                        Column = n.Column,
                        Sum =  n.Sum + grid[n.Row+1][n.Column]
                    });
                }
            }

            return  min;
        }
        
        public class Point
        {
            public int Row;
            public int Column;
            public int Sum;
        }
    }
}
