using System;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть строчку, в длиной n в которой каждый символ появляется нечетное число раз
    public class Task1374
    {
        public static string GenerateTheString(int n)
        {
            char[] r = new char [n];
            Array.Fill(r, 'p');
            if ((n & 1) != 1)
            {
                r[0] = 'z';
            }
            return new string(r);
        }
        
        public static string GenerateTheString_2(int n)
        {
            return (n & 1) == 1 ? new string('p', n) : new string('p', n - 1) + "z";
        }
    }
}
