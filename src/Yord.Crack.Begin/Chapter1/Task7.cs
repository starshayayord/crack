using System;

namespace Yord.Crack.Begin.Chapter1
{
    // Имеет изображение NxN, каждый пиксель - 4 байта
    // Необходимо повернуть изображение на 90 градусов
    public class Task7
    {
        //PERFECT
        public static int[][] RotateClockwise(int[][] img)
        {
            var matrixSize = img.Length;
            for (var layer = 0; layer < matrixSize / 2; layer++)
            {
                var endIndex = matrixSize - 1 - layer;
                for (var elementIndex = layer; elementIndex < endIndex; elementIndex++)
                {
                    var topLeft = img[layer][elementIndex+layer]; //1
                    img[layer][elementIndex+layer] = img[endIndex - elementIndex][layer]; // 13 -> 1
                    img[endIndex - elementIndex][layer] = img[endIndex][endIndex - elementIndex]; //16 -> 13
                    img[endIndex][endIndex - elementIndex] = img[elementIndex+layer][endIndex];  // 4 -> 16
                    img[elementIndex + layer][endIndex] = topLeft; // 4 -> 1
                }
            }

            return img;
        }
        

        // память на доп массив, сложность N^2
        public static int[,] Rotate(int[,] img)
        {
            var n = (int) Math.Sqrt(img.Length);
            var rotated = new int[n, n];

            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    var newI = n - i - 1;
                    rotated[newI, j] = img[i, j];
                }
            }

            return rotated;
        }
    }
}
