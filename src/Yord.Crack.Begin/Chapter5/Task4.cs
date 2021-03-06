using System;

namespace Yord.Crack.Begin.Chapter5
{
    // для положительного числа вывести ближайшее наименьшее и наибольшее числа с тем же кол-вом единичных битов
    public class Task4
    {
        public class Result
        {
            public int Min { get; set; }

            public int Max { get; set; }
        }

        public static Result GetMaxMinSameBitsMath(int n)
        {
            return new Result
            {
                Min = GetMinMath(n),
                Max = GetMaxMath(n)
            };
        }

        private static int GetMaxMath(int n)
        {
            var c = n;
            var c0 = 0; // кол-во завершающих нулей
            var c1 = 0; // размер последующего блока единиц
            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            if (c0 + c1 == 0 || c0 + c1 == 31) return -1;
            var p = c0 + c1;
            //необходимо:
            //установить Рый бит
            //сбросить все биты после Р
            //установить биты с 0 по (с1-2), т.е. всего с1-1 битов
            n += (int) Math.Pow(2, c0) - 1; //установим завершающие нули в 0, получив Р завершающих единиц
            n += 1; //сбросим первые Р единиц и установим бит в Рой позиции
            n += (int) Math.Pow(2, c1 - 1) - 1; //установим завершающие (c1-1) нулей в единицы
            return n;
            //по сути решение сводится к:
            // = n+(int)Math.Pow(2, c0) - 1 + 1 + (int) Math.Pow(2, c1 - 1) - 1 = 
            // n + (int)Math.Pow(2, c0) + (int) Math.Pow(2, c1 - 1) -1
            //что можно записать как 
            // = n + (1 << c0) + (1 << (c1 -1)) -1;
        }

        private static int GetMinMath(int n)
        {
            var c = n;
            var c0 = 0; // размер блока соседних с ними нулей
            var c1 = 0; // кол-во конечных единиц
            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            if (c == 0) return -1;

            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            var p = c0 + c1;
            // необходимо:
            // сбросить Рый бит
            // установить все биты после Р
            // сбросить биты с 0 по (c0-1)
            n -= (int) Math.Pow(2, c1) - 1; //удалили завершающие единицы
            n -= 1;//установили все биты после Р (переключили завершающие нули)
            n -= (int) Math.Pow(2, c0 - 1) - 1; //сброс ПОСЛЕДУЮЩИХ (с0-1) нулей 
            return n;
            //по сути решение сводится к:
            // = n - (int) Math.Pow(2, c1) - 1  +1 -( (int) Math.Pow(2, c0 - 1) - 1)
            // = n - Math.Pow(2, c1)  - Math.Pow(2, c0 - 1) +1
            //что можно записать как 
            // = n - (1 << c1) - (1 << (c0 -1)) +1;
        }

        public static Result GetMaxMinSameBits(int n)
        {
            return new Result
            {
                Min = GetMin(n),
                Max = GetMax(n)
            };
        }

        private static int GetMax(int n)
        {
            //допустим Р - позиция самого правого незавершающего нуля
            var c = n;
            var c0 = 0;
            var c1 = 0;
            // двигаем до первой единицы, т.е. с0 - кол-во нулей справа от Р
            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            //двигаем дальше до первого нуля, т.е. c1 - кол-во единиц справа от Р
            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            // все единицы уже максимально слева, то большего числа с таким же кол-вом бит не существует
            if (c0 + c1 == 31 || c0 + c1 == 0)
            {
                return -1;
            }

            // позиция крайнего правого незавершающего нуля
            var p = c0 + c1;

            n |= 1 << p; // установили Рый бит в единицу
            n &= ~((1 << p) - 1); //сбросили все биты правее Р
            n |= (1 << (c1 - 1)) - 1; //вставили с1-1 единиц справа от Р
            return n;
        }


        private static int GetMin(int n)
        {
            //допустим Р - позиция самой право незаввершающей единицы
            var c = n;
            var c0 = 0;
            var c1 = 0;
            // двигаем до первого нуля, т.е. с1 - кол-во единиц справа от Р
            while ((c & 1) == 1)
            {
                c1++;
                c >>= 1;
            }

            //если слева не осталось единиц, то числа меньше с тем же кол-во единиц быть не может
            if (c == 0)
            {
                return -1;
            }

            //двигаем до первой единицы, т.е. с0 - кол-во нулей справа от Р
            while ((c & 1) == 0 && c != 0)
            {
                c0++;
                c >>= 1;
            }

            var p = c0 + c1;
            n &= ~0 << (p + 1); //сбросили биты от [P,0]
            var mask = (1 << (c1 + 1)) - 1; //кол-во единиц справа от Р, плюс одна инвертированная
            n |= mask << (c0 - 1); //сдвигаем эти единицы до позиции справа от Р
            return n;
        }
    }
}
