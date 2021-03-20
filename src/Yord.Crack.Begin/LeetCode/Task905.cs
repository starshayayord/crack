namespace Yord.Crack.Begin.LeetCode
{
    //0 <= A[i] <= 5000, вернуть массив из четных,за которыми следуют нечетные
    public class Task905
    {
        public static int[] SortArrayByParity(int[] A)
        {
            int i = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if ((A[j] & 1) != 1)
                {
                    int t = A[i];
                    A[i++] = A[j];
                    A[j] = t;
                }
            }

            return A;
        }
    }
}
