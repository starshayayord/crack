using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task1217
    {
        public static int MinCostToMoveChips(int[] position)
        {
            var even = 0;
            var odd = 0;
            //считаем, на каких позицяих монет больше.
            //Нечетные к нечетным или четные к четным переходят бесплатно
            for (var i = 0; i < position.Length; i++)
            {
                if ((position[i] & 1) == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            //двигать за 1 будем те, которых меньше
            return Math.Min(even, odd);
        }
    }
}
