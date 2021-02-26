using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // количество счастливых пар: nums[i] == nums[j] при i < j.
    // Например 1,1  - 1 пара. 1-1-1 - 3 пары.
    public class Task1512
    {
        public int HappyPairsTime(int[] nums)
        {
            var happyPairs = 0;
            var map = new Dictionary<int, int>();
            foreach (var n in nums)
            {
                if (map.ContainsKey(n))
                {
                    // Первый раз (первая пара) map[n]=1, т.к. второе число можно соединить с одним предыдущим.
                    // Второй раз найденное третье число можно будет соединить с предыдущими двумя.
                    // Третий раз найденное 4ое число можно соединить с предыдущими тремя и т.д.
                    // Т.е. каждый раз прибавляем кол-во предыдущих чисел 
                    happyPairs += map[n];
                    map[n]++;
                }
                else
                {
                    map[n] = 1;
                }
            }

            return happyPairs;
        }
        
        
        public int HappyPairsSpace(int[] nums)
        {
            var happyPairs = 0;
            var a = new int[101];
            foreach (var n in nums)
            {
                a[n]++;
            }

            // каждое число n можно соединить в пару со всеми предудущимим (n-1).
            // Но соединить первое и второе, это то же самое, что сединить второе и первое,
            // значит делим кол-во возможных пар на 2.
            foreach (var n in a)
            {
                happyPairs += n * (n - 1) / 2;
            }
            return happyPairs;
        }
    }
}
