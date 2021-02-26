namespace Yord.Crack.Begin.LeetCode
{
    // вернуть, сколько шагов нужно, чтоб число стало равно нулю. можно делить на 2 и вычитать 1
    public class Task1342
    {
        public static int NumberOfSteps(int num)
        {
            if (num == 0) return 0;
            int steps = 0;
            while (num > 0)
            {
                // если число четное, то только делим на 2 (+1 шаг), если нечетное, то еще и вычитаем 1 (+1) шаг.

                steps += 1 + (num & 1);
                num >>= 1;
            }

            // Для последней единицы добавится лишнее деление на 2, его и вычитаем
            return steps - 1;
        }
    }
}
