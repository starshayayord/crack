namespace Yord.Crack.Begin.LeetCode
{
    // вернуть n уникальных int, которые в сумме дают 0, 1 <= n <= 1000
    public class Task1304
    {
        public static int[] SumZero(int n)
        {
            int[] res = new int[n];
            int l = 0;
            int r = n - 1;
            while (l < r)
            {
                res[l++] = -l;
                res[r--] = -res[l - 1];
            }

            return res;
        }

        public static int[] SumZero_2(int n)
        {
            int i = 0;
            int[] r = new int[n];
            if ((n & 1) == 1)
            {
                i++; //r[0] == 0;
            }

            while (i < n)
            {
                r[i] = n - i;
                i++;
                r[i] = -r[i - 1];
                i++;
            }

            return r;
        }
    }
}
