using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // дана верхняя и нижняя граница интервала (включительно).
    // Вернуть все числа, которые делятся нацело на каждую из цифр, из которых оно состоит
    public class Task728
    {
        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                int n = i;
                for (; n > 0; n /= 10)
                {
                    int digit = n % 10;
                    if (digit == 0 || i % digit != 0)
                    {
                        break;
                    }
                }

                if (n == 0)
                {
                    result.Add(i);
                }
            }

            return result;
        }
        
        public static IList<int> SelfDividingNumbers_Str(int left, int right)
        {
            List<int> result = new List<int>();
            for (int i = left; i <= right; i++)
            {
                string n = i.ToString();
                bool fits = true;
                for (int j =0; j< n.Length; j++)
                {
                    
                    if (n[j] == '0' || i % (n[j] - '0') != 0)
                    {
                        fits = false;
                        break;
                    }
                }

                if (fits)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}
