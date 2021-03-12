namespace Yord.Crack.Begin.LeetCode
{
    // повернуть изображение относительно горизонтали( каждая строчка задом наперед),
    // а потом инвертнуть все значения
    public class Task832
    {
        public static int[][] FlipAndInvertImage(int[][] image)
        {
            int c = image[0].Length;
            bool isOdd = c % 2 == 1;
            foreach (var row in image)
            {
                int j = 0;
                for (; j < c / 2; j++)
                {
                    int t = row[j];
                    row[j] = row[c - j - 1]^1;
                    row[c - j - 1] = t^1;
                }

                if (isOdd)
                {
                    row[j] = row[j]^1;
                }
            }

            return image;
        }
        
        public static int[][] FlipAndInvertImage_2(int[][] image)
        {
            int c = image[0].Length;
            for (int i=0 ; i< image.Length; i++)
            {
                //пока не прошли до середины массива (т.е. включая средний нечный элемент, если он есть)
                for (int j = 0; j * 2 < c; j++)
                {
                    // Если элементы, которые надо поменять НЕ равны,
                    // то при смене их друг на друга они инвертируются, а потом еще раз инвертируются,
                    // т.е. каждый из них 2 раза меняется на противоположный, ничего можно не делать.
                    // Если элементы, которые надо поменять равны,
                    // то при флипе никаких изменений не будет, операцию модно опустить.
                    // Достаточно инвертировать значение обоих
                    if (image[i][j] == image[i][c - j - 1])
                    {
                        image[i][j] = image[i][c - j - 1] ^= 1;
                    }
                }
            }

            return image;
        }
    }
}
