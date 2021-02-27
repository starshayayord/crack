namespace Yord.Crack.Begin.LeetCode
{
    // вернуть разницу между произведением и суммой цифр в числе
    public class Task1281
    {
        public static int SubtractProductAndSum(int n)
        {
            int sum = 0;
            int prod = 1;
            for (;n > 0; n/=10)
            {
                int i = n % 10;
                sum += i;
                prod *= i;
            }

            return prod - sum;
        }
    }
}
