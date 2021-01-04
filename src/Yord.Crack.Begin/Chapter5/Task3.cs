using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter5
{
    // найти самую длинную последовательность единиц, если в числе мб заменен только один 0.
    public class Task3
    {
        private const int BitsInByte = 8;
        public static int GetMaxSequence(int num)
        {
            var sequences = GetSequences(num);
            return GetMaxOnesSequence(sequences);
        }
        
        // получаем последовательность повторений
        // последовательность начинается с кол-ва нулей, далее чередуется
        // 11011101111 => [0, 4, 1, 3, 1, 2, 21], т.к. 32 бита и считаем слева, постепенно сдвигая
        private static List<int> GetSequences(int n)
        {
            var t = Convert.ToString(n, 2);
            var searchFor = 0;
            var counter = 0;
            var sequences = new List<int>();
            for (var i = 0; i < sizeof(int) * BitsInByte; i++)
            {
                var currentBit = n & 1;
                if (currentBit != searchFor)
                {
                    sequences.Add(counter);
                    searchFor = currentBit;
                    counter = 0;
                }

                counter++;
                n >>= 1;
            }
            sequences.Add(counter);
            return sequences;
        }

        // прыгаем по кол-вам нулей и пытаемся прибавить кол-во единиц слева и/или справа, если возможно
        private static int GetMaxOnesSequence(List<int> sequences)
        {
            var maxSeq = 1; //  как минимум 1 ноль мы можем заменить на 1
            for (var i = 0; i < sequences.Count; i += 2)
            {
                var tempMaxSeq = 0;
                var zerosCount = sequences[i];
                var onesOnRight = i - 1 >= 0 ? sequences[i - 1] : 0;
                var onesOnLeft = i + 1 < sequences.Count ? sequences[i +1 ] : 0;
                if (zerosCount == 1)
                {
                    tempMaxSeq = onesOnRight + 1 + onesOnLeft;
                }

                if (zerosCount > 1)
                {
                    tempMaxSeq = 1 + Math.Max(onesOnRight, onesOnLeft);
                }

                if (zerosCount == 0)
                {
                    tempMaxSeq = Math.Max(onesOnRight, onesOnLeft);
                }

                maxSeq = Math.Max(tempMaxSeq, maxSeq);
            }

            return maxSeq;
        }
    }
}
