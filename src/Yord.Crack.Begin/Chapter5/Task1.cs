namespace Yord.Crack.Begin.Chapter5
{
    //для 32 разрядных M и N написать вставку M в N начиная с i и до j позиции (помещается гарантированно)
    //N = 10000000000 M=10011, i=2, j=6 => 10001001100
    public class Task1
    {
        public static int Insert(int n, int m, int i, int j)
        {
            var mLen = j - i;
            for (var c = 0; c <= mLen; c++)
            {
                var value = GetBit(m, c);
                n = SetBit(n, i + c, value);
            }

            return n;
        }
        
        public static int Insert2(int n, int m, int i, int j)
        {
             m <<= i;
             return n | m;
        }

        private static int SetBit(int n, int i, int value)
        {
            var mask = ~(1 << i);
            return n & mask | (value << i);
        }

        private static int GetBit(int m, int i)
        {
            var mask = 1 << i;
            var isOne = (m & mask) != 0;
            return isOne ? 1 : 0;
        }
    }
}
