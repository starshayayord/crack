using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //2 <= n, m <= 100
    public class Task1337
    {
        public static int[] KWeakestRows(int[][] mat, int k)
        {
            var map = new List<int>[101];
            for (var i = 0; i < mat.Length; i++)
            {
                var s = 0;
                for (var j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 0)
                    {
                        break;
                    }

                    s++;
                }

                if (map[s] != null)
                {
                    map[s].Add(i);
                }
                else
                {
                    map[s] = new List<int>{i};
                }
            }

            var ki = 0;
            var res = new int[k];
            for (var i = 0; ki < k; i++)
            {
                if (map[i] == null)
                {
                    continue;
                }

                foreach (var r in map[i])
                {
                    res[ki++] = r;
                    if (ki == k)
                    {
                        return res;
                    }
                }
            }

            return res;
        }

        public static int[] KWeakestRows2(int[][] mat, int k)
        {
            var res = new int[k];
            var visited = new bool [mat.Length];
            var ki = 0;
            // идем по столбцам и внутри по строкам. За счет этого среди строк с одинаковым первым индексов нуля
            // строка, которая идет раньше. будет добавлена раньше
            var jMax = mat[0].Length - 1;
            for (var j = 0; j <= jMax; j++)
            {
                for (var i = 0; i < mat.Length; i++)
                {
                    if (visited[i]) //уже добавили эту строку
                    {
                        continue;
                    }
                    //если в этой строке и столбце 0
                    if (mat[i][j] == 0)
                    {
                        //значит это строка, которая имеет ноль в этом индексе и она стоит раньше
                        res[ki++] = i;
                        visited[i] = true;
                    }

                    if (ki == k)//если достаточно, то выходим
                    {
                        return res;
                    }
                }
            }

            //выше упустили строки, в которых никогда не стоит 0
            for (var i = 0; i < mat.Length; i++)
            {
                if (mat[i][mat[0].Length - 1] == 1)
                {
                    res[ki++] = i;
                }
                if (ki == k)
                {
                    return res;
                }
            }

            return res;
        }
    }
}
