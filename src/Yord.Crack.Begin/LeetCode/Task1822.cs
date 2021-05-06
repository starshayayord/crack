namespace Yord.Crack.Begin.LeetCode
{
    // вернуть знак произведения всех элементов
    public class Task1822
    {
        public static int ArraySign(int[] nums)
        {

            var r = 1;
            foreach (var n in nums)
            {
                if (n == 0)
                {
                    return 0;
                }

                if (n < 0)
                {
                    r *= -1;
                }
            }

            return r;
        }
    }
}
