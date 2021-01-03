using System;
using System.Text;

namespace Yord.Crack.Begin.Chapter5
{
    //вывести двоичное представление double (0, 1). если не хватает 32 бит, то ошибка
    public class Task2
    {
        // двоичное число 0.101 = 1 * 2^-1 + 0 * 2^-2 + 1 * 2^-3
        // то есть 1 * 0.5 + 0 * 0.05 + 1 * 0.05
        // будем сравнивать каждую цифру с текущим разрядом (0.5, 0.05...).
        // Если цифра больше или равно, то это 1, иначе - 0.
        // если 1, то вычитаем добавленное
        public static string Convert(double value)
        {
            var toCompare = 0.5;
            var sb = new StringBuilder("0.");
            while (value > 0)
            {
                if (sb.Length >= 32)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value >= toCompare)
                {
                    sb.Append(1);
                    value -= toCompare;
                }
                else
                {
                    sb.Append(0);
                }

                toCompare /= 2;
            }

            return sb.ToString();
        }
    }
}
