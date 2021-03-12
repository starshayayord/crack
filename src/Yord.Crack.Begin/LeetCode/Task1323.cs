using System;
using System.Text.RegularExpressions;

namespace Yord.Crack.Begin.LeetCode
{
    // Вернуть максимальноe число, которое можно получить, изменив максимум одну цифру
    //6->9 или 9->6
    public class Task1323
    {
        public static int Maximum69Number(int num)
        {
            int sixIndex = -1;
            int n = num;
            for (int i = 1; n > 0; i *= 10, n /= 10)
            {
                if (n % 10 == 6)
                {
                    sixIndex = i;
                }
            }

            return sixIndex == -1 ? num : num + 3 * sixIndex;
        }

        public static int Maximum69Number_3(int num)
        {
            int i = num.ToString().Length - 1;
            int n = num;
            while (n > 0)
            {
                int s = (int) Math.Pow(10, i);
                if (n / s == 6)
                {
                    num += 3 * (int) Math.Pow(10, i);
                    break;
                }

                i--;
                n -= s * 9;
            }

            return num;
        }

        public static int Maximum69Number_2(int num)
        {
            string s = num.ToString();
            int i = 0;
            for (; i < s.Length; i++)
            {
                if (s[i] == '6')
                {
                    break;
                }
            }

            return i == s.Length ? num : num + 3 * (int) Math.Pow(10, s.Length - i - 1);
        }

        public static int Maximum69Number_4(int num)
        {
            return int.Parse(new Regex("6").Replace(num.ToString(), "9", 1));
        }
    }
}
