namespace Yord.Crack.Begin.LeetCode
{
    public class Task476
    {
        public static int FindComplement2(int num)
        {
            //сумма числа и его комплимента имеет все единицы во всех разрядах
            //00110, 011001, the sum is 111111.
            return GetMask(num) - num;
        }
        
        public static int FindComplement(int num)
        {
            //0000  0000  0000  0101 (num)
            //0000  0000  0000  0111 (mask)
            //0000  0000  0000  0010 (XOR)
            var mask = GetMask(num);
            return num ^ mask;
        }

        private static int GetMask(int n)
        {
            var mask = 0;
            while (n > 0)
            {
                mask <<= 1;
                mask += 1;
                n >>= 1;
            }

            return mask;
        }
    }
}
