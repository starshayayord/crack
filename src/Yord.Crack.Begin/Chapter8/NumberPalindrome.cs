namespace Yord.Crack.Begin.Chapter8
{
    // Проверить, является ли число - палиндромом
    public class NumberPalindrome
    {
        // Если развернутое число равно исходному, значит это палиндром.
        public static bool IsPalindrome(int n)
        {
            var x = n;
            var reversed = 0;
            while (x > 0)
            {
                reversed = reversed * 10 + x % 10;
                x /= 10;
            }

            return reversed == n;
        }
    }
}
