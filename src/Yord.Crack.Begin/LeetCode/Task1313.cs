using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Дан сжатый массив. Каждая пара - это [частота, значение] = [nums[2*i], nums[2*i+1]].
    // Пример: [1,2,3,4] Первая пара [1,2], т.е. значение 2 с частотой 1. вторая пара [3,4], получаем 4 с частотой 3.
    // Выходная последовательность [2,4,4,4]
    public class Task1313
    {
        public static int[] DecompressRLElist(int[] nums)
        {
            var r = new List<int>();
            for (int i = 0; i < nums.Length; i+=2)
            {
                r.AddRange(Enumerable.Repeat(nums[i+1], nums[i]));
            }

            return r.ToArray();
        }
        
        public static int[] DecompressRLElist2(int[] nums)
        {
            int s = 0;
            // на один цикл больше, но меньше выделений памяти и не нужно конвертировать в массив в конце
            for (int i = 0; i < nums.Length; i += 2)
            {
                s += nums[i];
            }

            int[] r = new int [s];
            int ri = 0;
            for (int i = 0; i < nums.Length; i+=2)
            {
                // внутри все тот же цикл for
                Array.Fill(r,nums[i+1],ri, nums[i]);
              ri += nums[i];
            }

            return r;
        }
    }
}
