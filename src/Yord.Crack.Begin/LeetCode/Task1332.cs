using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // строка состоит только из А и Б
    //за шаг можно убрать 1 подпоследовательность (важен только порядок, но может прерываться),
    //которая явлеяется палиндромом.
    //вернуть кол-во шагов для пустой строки
    public class Task1332
    {
        public static int RemovePalindromeSub(string s)
        {
            //строка уже пустая
            if (string.IsNullOrEmpty(s)) return 0;
            //строка уже палиндром, один шаг.
            //уберем сначала все А, потом все Б, т.е. 2 шага
            var n = s.Length - 1;
            for (int i = 0; i <=n; i++)
            {
                if (s[i] != s[n - i])
                {
                    return 2;
                }
            }

            return 1;
        }
    }
}
