namespace Yord.Crack.Begin.Chapter8
{
    //два числа равны 0 и 1, а каждое последующее число равно сумме двух предыдущих чисел
    public class Fibonacci
    {
        //сложность 2^N, т.к. каждый вызов-потомок имеет 2 дочерних узла
        //т.е. детей - два, внуков - 4, правнуков - 8 и т.д.
        public static int GetFibonacci(int i)
        {
            if (i == 0 || i == 1) return i;
            return GetFibonacci(i - 1) + GetFibonacci(i - 2);
        }
        
        // глубина примерно N, два дочерних узла, сложность 2N
        public static int GetFibonacciMemorisation(int i)
        {
            return GetFibonacciMemorisation(i, new int[i + 1]);
        }
        
        private static int GetFibonacciMemorisation(int i, int[] memo)
        {
            if (i == 0 || i == 1) return i;
            if (memo[i] == 0)
            {
                memo[i] = GetFibonacciMemorisation(i - 1, memo) + GetFibonacciMemorisation(i - 2, memo);
            }

            return memo[i];
        }

        // Чтобы получить число фибоначчи, надо сложить предыдущее и пред-предыдущее
        // для исходного  случая пред-предыдущее=0, предыдущее=1;
        // Новое число будем вычислять их сложением
        // Чтобы вычислить следующее за новым, нужно будет:
        // помнить новое (которое станет предыдущим) и предыдущее (которое станет пред-предыдущим).
        // т.е. надо запоминать предыдущее число, чтоб использовать его как пред-предыдущее в следующей итерации
        public static int GetFibonacciDinProg(int i)
        {
            if (i == 0) return 0;
            var a = 0; // первое пред-предыдущее
            var b = 1; // первое предыдущее
            for (var n = 2; n < i; n++)
            {
                var c = a + b; //новое число
                a = b; // запомнили предыдущее, чтоб оно стало пред-предыдущим в следующей итерации
                b = c; // запомнили новое, чтоб оно стало предыдущим в следующей итерации
            }

            // сложили F(i-2) + F(i-1), т.е пред-предыдущее и предыдущее с последней итерации (до n-1, т.к. n<i)  
            return a + b;
        }
    }
}
