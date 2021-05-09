namespace Yord.Crack.Begin.LeetCode
{
    // вернуть кол-во разных бит в числах
    public class Task461
    {
        public static int HammingDistance(int x, int y)
        {
            var n = x ^ y;
            var r = 0;
            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    r+=n & 1;
                }

                n >>= 1;
            }

            return r;
        }
    }
}
