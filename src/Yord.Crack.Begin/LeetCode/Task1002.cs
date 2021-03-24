using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // строчки из букв в нижнем регистре. вернуть список символов, общий для всех строк
    // Повторить символ столько раз, сколько он повторяется во всех строках.
    public class Task1002
    {
        public static IList<string> CommonChars(string[] A)
        {
            int[][] source = new int[A.Length][];
            for (int i = 0; i < A.Length; i++)
            {
                source[i] = new int[26];
            }

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    source[i][A[i][j] - 'a']++;
                }
            }

            List<string> r = new List<string>();
            for (int i = 0; i < source[0].Length; i++)
            {
                int f = int.MaxValue;
                for (int j = 0; j < source.Length; j++)
                {
                    f = Math.Min(source[j][i], f);
                    if (f == 0)
                    {
                        break;
                    }
                }
                for (int k = 0; k < f; k++)
                {
                    r.Add(((char) (i + 'a')).ToString());
                }
            }

            return r;
        }
    }
}
