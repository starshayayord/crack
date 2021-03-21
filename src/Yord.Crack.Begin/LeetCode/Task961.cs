using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // В массиве длиной 2N есть N+1 уникальных, и всего 1 повторен N раз.
    // Вернуть повторяющийся элемент, 0 <= A[i] < 10000
    public class Task961
    {
        public static int RepeatedNTimes(int[] A)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (s.Contains(A[i]))
                {
                    return A[i];
                }

                s.Add(A[i]);
            }

            return -1;
        }

        public static int RepeatedNTimes_Compare(int[] A)
        {
            //т.к. повторяющихся элементов N, значит если проверять попарно то можно перескочить через одинаковые
            //если же проверять три соседних, то обязательно наткнемся на повторяющийся
            //, т.к. их слишком много, чтоб стоять более разряженно, чем через 1.
            
            for (int i = 2; i < A.Length; i++)
            {
                if (A[i] == A[i - 1] || A[i] == A[i - 2])
                {
                    return A[i];
                }
            }
            //единственный пропущенный кейс - это A[0], т.е. [x, x, y, z] или [x, y, z, x]
            return A[0];
        }
    }
}
