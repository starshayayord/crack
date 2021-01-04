using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter5
{
    // найти самую длинную последовательность единиц, если в числе мб заменен только один 0.
    public class Task3
    {
        // достаточно знать длину текущей единиц и предыдущей последовательности единиц
        public static int GetMaxSequence(int num)
        {
            //в числе только 1, не будет уменьшаться при >> 1, особый случай
            if (num == -1) return sizeof(int) * BitsInByte;
            var maxSeqL = 1; //  как минимум один ноль можно изменить на единицу
            var curSeqL = 0;
            var prevSeqL = 0;
            while (num != 0)
            {
                var curBit = num & 1;
                if (curBit == 1) // текущий бит равен 1
                {
                    curSeqL++; // увеличили текущую последовательность на 1
                }
                else // обнаружили ноль
                {
                    var nextBit = num & 2; // какой бит следующий, т.е. равна ли длина последовательности нулей единице
                    // если да, то длина предыдущей последоватльности равна кол-ву единиц до этого нуля,
                    // иначе сбрасываем длину предыдущей последовательности единиц, т.к. она не мб соединена
                    prevSeqL = nextBit == 0 ? 0 : curSeqL;
                    //  текущая длина последовательности единиц равна нулю
                    curSeqL = 0;
                }

                // макс длина текущей последоватльности = длина предыдущей + плюс длина текущей + длина нолика(1)
                maxSeqL = Math.Max(prevSeqL + 1 + curSeqL, maxSeqL);
                num >>= 1;
            }

            return maxSeqL;
        }
        private const int BitsInByte = 8;
        // O(sizeof(int)*BitsInByte), но неоптимально по памяти
        public static int GetMaxSequence2(int num)
        {
            var sequences = GetSequences(num);
            return GetMaxOnesSequence(sequences);
        }
        
        // получаем последовательность повторений
        // последовательность начинается с кол-ва нулей, далее чередуется
        // 11011101111 => [0, 4, 1, 3, 1, 2, 21], т.к. 32 бита и считаем слева, постепенно сдвигая
        private static List<int> GetSequences(int n)
        {
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
