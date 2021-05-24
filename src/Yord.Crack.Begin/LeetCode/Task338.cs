namespace Yord.Crack.Begin.LeetCode
{
    public class Task338
    {
        //массив n+1 элементов, элемент - это кол-во единиц в индексе
        public static int[] CountBits2(int n)
        {
            //кол-во единиц в 3 и в 3*2 - равно,т.к.*2 = сдвиг на 1 бит
            //значит кол-во единиц в 7 - это кол-во единиц в 7>>1 (в 3) и если число нечетное,
            //то в конце стоит 1, значит +1

            var r = new int [n + 1];
            for (var i = 0; i <= n; i++)
            {
                r[i] = r[i >> 1] + (i & 1);
            }

            return r;
        }

        public int[] CountBits(int n)
        {
            var r = new int [n + 1];
            for (int i = 0; i <= n; i++)
            {
                r[i] = CountBitsN(i);
            }

            return r;
        }

        private int CountBitsN(int i)
        {
            var c = 0;
            while (i > 0)
            {
                if ((i & 1) > 0)
                {
                    c++;
                }

                i >>= 1;
            }

            return c;
        }
    }
}
