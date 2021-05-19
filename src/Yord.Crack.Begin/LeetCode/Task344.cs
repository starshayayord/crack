using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task344
    {
        public static void ReverseStringXor(char[] s)
        {
            var l = 0;
            var r = s.Length - 1;
            while (l < r)
            {
                s[l] ^= s[r];
                s[r] ^= s[l];
                s[l] ^= s[r];
                l++;
                r--;
            }
        }

        public static void ReverseString(char[] s)
        {
            var l = 0;
            var r = s.Length - 1;
            while (l < r)
            {
                var t = s[l];
                s[l++] = s[r];
                s[r--] = t;
            }
        }

        public static void ReverseStringRev(char[] s)
        {
            Array.Reverse(s);
        }
    }
}
