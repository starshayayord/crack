using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.AdditionalTasks
{
    public class ColorTask
    {
        public static void ColorPart2(char[,] matrix, char color, int r, int c)
        {
            var initialColor = matrix[r, c];
            ColorPartRec(matrix, initialColor, r, c, color);
        }

        private static void ColorPartRec(char[,] matrix, char initialColor, int r, int c, char color)
        {
            if (!IsInBound(r, matrix.Length - 1) || !IsInBound(c, matrix.GetLength(0) - 1) ||
                matrix[r, c] != initialColor)
            {
                return;
            }

            matrix[r, c] = color;
            ColorPartRec(matrix, initialColor, r + 1, c, color); //up
            ColorPartRec(matrix, initialColor, r - 1, c, color); //down
            ColorPartRec(matrix, initialColor, r, c - 1, color); //left
            ColorPartRec(matrix, initialColor, r, c + 1, color); //right
        }

        public static void ColorPart(char[,] matrix, char color, int r, int c)
        {
            var initialColor = matrix[r, c];
            var maxRow = matrix.Length - 1;
            var maxColumn = matrix.GetLength(0) - 1;
            var queue = new Queue<Tuple<int, int>>();
            queue.Enqueue(new Tuple<int, int>(r, c));
            while (queue.Any())
            {
                var (r1, c1) = queue.Dequeue();
                if (!IsInBound(r1, maxRow) || !IsInBound(c1, maxColumn) || matrix[r1, c1] != initialColor)
                {
                    continue;
                }

                matrix[r1, c1] = color;
                queue.Enqueue(new Tuple<int, int>(r1 + 1, c1)); //up
                queue.Enqueue(new Tuple<int, int>(r1 - 1, c1)); //down
                queue.Enqueue(new Tuple<int, int>(r1, c1 - 1)); //left
                queue.Enqueue(new Tuple<int, int>(r1, c1 + 1)); //right
            }
        }

        private static bool IsInBound(int coord, int maxCoord)
        {
            return coord >= 0 && coord <= maxCoord;
        }
    }
}
