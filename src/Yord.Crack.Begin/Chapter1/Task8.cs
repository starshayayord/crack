using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter1
{
    // Если элемент матрицы MxN равен 0, то столбец и строка обнуляются
    public class Task8
    {
        //PERFECT (чуть проще оценить сложность)
        public static int[][] ToZero(int[][] source)
        {
            var row = new bool[source.Length];
            var column = new bool[source[0].Length];
            for (var r = 0; r < source.Length; r++)
            {
                for (var c = 0; c < source[r].Length; c++)
                {
                    if (column[c])
                    {
                        continue;
                    }
                    if (source[r][c] == 0)
                    {
                        row[r] = true;
                        column[c] = true;
                        break;
                    }
                }
            }

            for (var r = 0; r < row.Length; r++)
            {
                if (row[r])
                {
                    source[r] = new int [source[r].Length];
                }
            }
            
            for (var c = 0; c < column.Length; c++)
            {
                if (column[c])
                {
                    for (var i = 0; i < source.Length; i++)
                    {
                        source[i][c] = 0;
                    }
                }
            }

            return source;
        }
        
        //  сложнее оцнить сложность
        public static int[][] ToZero2(int[][] source)
        {
            var zeroColumns = new HashSet<int>();
            for (var r = 0; r < source.Length; r++)
            {
                for (var c = 0; c < source[r].Length; c++)
                {
                    if (zeroColumns.Contains(c))
                    {
                        continue;
                    }

                    if (source[r][c] == 0)
                    {
                        source[r] = new int[source[r].Length]; //replace row
                        foreach (var t in source)
                        {
                            t[c] = 0; //replace columns
                        }

                        zeroColumns.Add(c);
                        break;
                    }
                }
            }

            return source;
        }
    }
}
