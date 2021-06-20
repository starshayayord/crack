namespace Yord.Crack.Begin.LeetCode
{
    public class Task509
    {
        public static int Fib3(int n)
        {
            if(n<=1)
            {
                return n;
            }
        
            int f0 = 0;
            int f1 = 1;
            //пока не прошли n-2 раз
            //t = Fib(0)+Fib(1) 
            //f0 = большее из предыдущих
            //f1 = промежуточная сумма
            for(int i = 2; i <= n; i++)
            {
                int t = f0 + f1;
                f0 = f1;
                f1 = t;
            }
        
            return f1;
        }
        public static int Fib(int n)
        {
            return n switch
            {
                0 => 0,
                1 => 1,
                _ => Fib(n - 1) + Fib(n - 2)
            };
        }
        
        public static int Fib2(int n)
        {
            return Fib2(n, new int[31]);
        }

        private static int Fib2(int n, int[] cache)
        {
            if (cache[n] != 0)
            {
                return cache[n];
            }

            if (n == 0 || n == 1)
            {
                return n;
            }

            var r = Fib2(n - 1, cache) + Fib2(n - 2, cache);
            cache[n] = r;
            return r;
        }
    }
}
