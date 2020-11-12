using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter1
{
    // Если элемент матрицы MxN равен 0, то столбец и строка обнуляются
    public class Task8
    {
        public static int[][] ToZero(int[][] source)
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
