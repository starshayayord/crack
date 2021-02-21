namespace Yord.Crack.Begin.Chapter8
{
    // Рекурсивная функция для умножения двуз положительных целых чисел без использования оператора *
    // Допускается использование сложения, вычитания, поразрядного сдвига, но их кол-во должно быть минимально.
    public class Task5
    {
        public static int Multiply(int a, int b)
        {
            return a > b ? MultiplyIter(a, b) : MultiplyIter(b, a); // чтобы прокручивать while меньше раз
        }

        private static int MultiplyIter(int a, int times)
        {
            if (times == 0) return 0;
            if (times == 1) return a;
            var m = 1;
            var result = a;
            while (m < times)
            {
                if ((m << 1) > times)
                {
                    result += a;
                    m += 1;
                }
                else
                {
                    result <<= 1;
                    m <<= 1;
                }
            }

            return result;
        }
        
        public static int MultiplyRec2(int a, int b)
        {
            var bigger = a > b ? a : b;
            var smaller = a > b ? b : a;
            return MultiplyRecursive(bigger, smaller); // чтобы прокручивать рекурсию меньше раз
        }
        
        private static int MultiplyRecursive(int a, int times)
        {
            if (times == 0) return 0;
            if (times == 1) return a;
            var s = times >> 1; //  точно как-то делится на 2, т.к. оно >=2;
            // пытаемся получить половину.
            // Если times - четное, то получаем результат для times/2, а потом складываем в ним самим же
            // Если нечетное, то вторая половина будет получена для  times - times/2
            // например times=9. side1(times=4)  + side2 (times=5)
            var side1 = MultiplyRecursive(a, s); 
            var side2 = side1;
            if ((times & 1) == 1) // нечетное
            {
                side2 = side1 + a;
            }

            return side1 + side2;
        }

    }
    
    
}
