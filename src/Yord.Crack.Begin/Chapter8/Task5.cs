namespace Yord.Crack.Begin.Chapter8
{
    // Рекурсивная функция для умножения двуз положительных целых чисел без использования оператора *
    // Допускается использование сложения, вычитания, поразрядного сдвига, но их кол-во должно быть минимально.
    public class Task5
    {
        public static int Multiply(int a, int times)
        {
            var result = 0;

            while (times > 0)
            {
                if ((times & 1) == 1) // нечетное  
                {
                    result += a;
                    times -= 1;
                }
                else // четное
                {
                    result += a << 1;
                    times -= 2;
                }
            }

            return result;
        }
        
        public static int MultiplyRec(int a, int times)
        {
            if (times == 0) return 0;
            var r = 0;
            if ((times & 1) == 1) // нечетное  
            {
                r += a;
                r += MultiplyRec(a, times-1);
            }
            else // четное
            {
                r += a << 1;
                r += MultiplyRec(a, times-2);
            }
            
            return r;
        }

    }
    
    
}
