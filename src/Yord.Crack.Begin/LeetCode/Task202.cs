using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // заменить на сумму квадратов цифр из числа, повторить пока не станет 1 цифрой, которая:
    // Если 1, то true, иначе false
    public class Task202
    {
        // т.е. мы должны выйти, если n=1 если мы получили то же число, что уже получали до этого, т.е. зациклились
        public static bool IsHappy_FloydCycle(int n)
        {
            int slow = n;
            int fast = n;
            do
            {
                //первую итерацию f-s разделяет 1 шаг, вторую - два шага, и т.д.
                //когда-нибудь f-s будут разделены тем кол-вом шагов, которое является нужным для зацикливания
                slow = DigitsSquareSum(slow); 
                fast = DigitsSquareSum(fast); 
                if (fast == 1) return true;
                fast = DigitsSquareSum(fast);
                if (fast == 1) return true;
            } while (slow != fast);// увидели зацикливание

            return false;
        }

        private static int DigitsSquareSum(int n)
        {
            double s = 0;
            while (n != 0)
            {
                var d = n % 10;
                s += Math.Pow(d, 2);
                n /= 10;
            }

            return (int) s;
        }

        public static bool IsHappy(int n)
        {
            var s = new HashSet<int>();
            while (n != 1 && !s.Contains(n))
            {
                s.Add(n);
                var t = n;
                n = 0;
                while (t != 0)
                {
                    var d = t % 10;
                    n += (int) Math.Pow(d, 2);
                    t /= 10;
                }
            }

            return n == 1;
        }
    }
}
