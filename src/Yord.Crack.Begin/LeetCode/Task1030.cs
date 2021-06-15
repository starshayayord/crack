using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть координаты всех ячеек матрицы в зависимости от расстояния от центра (|r1 - r2| + |c1 - c2|)
    public class Task1030
    {
        public static int[][] AllCellsDistOrder(int rows, int cols, int rCenter, int cCenter)
        {
            var map = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < rows; i++)
            {
                var rowDistance = Math.Abs(rCenter - i);
                for (int j = 0; j < cols; j++)
                {
                    var distance = rowDistance + Math.Abs(cCenter - j);
                    if (map.ContainsKey(distance))
                    {
                        map[distance].Add(new []{i,j});
                    }
                    else
                    {
                        map.Add(distance, new List<int[]>{new []{i,j}});
                    }
                }
            }

            var r = new int [rows * cols][];
            var idx = 0;
            for(int i=0;  i< map.Count; i++)
            {
                foreach (var coord in map[i])
                {
                    r[idx++] = coord;
                }
            }
            return r;
        }
    }
}
