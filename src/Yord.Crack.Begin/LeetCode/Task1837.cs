namespace Yord.Crack.Begin.LeetCode
{
    // вернуть сумму цифр в n после конвертации в число по основанию k
    public class Task1837
    {
        public static int SumBase(int n, int k)
        {
            var r = 0;
            while (n > 0)
            {
                r += n % k;
                n /= k;
            }

            return r;
        }
    }
}
