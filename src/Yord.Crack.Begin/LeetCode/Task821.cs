using System;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task821
    {
        public static int[] ShortestToChar2(string s, char c)
        {
            var pos = -s.Length - 1; //в худшем случае символ последний
            var r = new int[s.Length];
            // идем слева направо, считаем расстояние от последнего найденного (слева)
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    pos = i;
                }

                r[i] = i - pos;
            }

            //идем справа налево(от последнего найденного),
            //считаем меньшее расстояние в предыдущим проходе и от последнего найденного (справа) 
            for (var i = pos - 1; i >= 0; i--)
            {
                if (s[i] == c)
                {
                    pos = i;
                }

                r[i] = Math.Min(r[i], pos - i);
            }

            return r;
        }
        public static int[] ShortestToChar(string s, char c)
        {
            var ri = 0;
            var r = new int[s.Length];
            var lastPos = -1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    while (ri <= i)
                    {
                        if (lastPos == -1)
                        {
                            lastPos = i;
                        }

                        var v = Math.Min(Math.Abs(ri - lastPos), i - ri);

                        r[ri] = v;
                        ri++;
                    }

                    lastPos = i;
                }
                else if (i == s.Length-1)
                {
                    while (ri <= i)
                    {
                        r[ri] = ri - lastPos;
                        ri++;
                    }
                }
            }

            return r;
        }
    }
}
