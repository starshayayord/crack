namespace Yord.Crack.Begin.Chapter5
{
    // поменять местами четные и нечетные биты числа (0 и 1, 2 и 3 и т.д.)
    public class Task7
    {
        public static int SwapBits(int n)
        {
            const int oddMask = 0xaaaaaaa;//101010....  маска для нечетных битов 1, 3...
            const int evenMask = 0x55555555;//....10101 маска для четных битов 0, 2...
            var evenPart = (n & evenMask) << 1; // возьмем все четные биты и сместим влево, сделав их нечетными
            var oddPart = (n & oddMask) >> 1; //возьмем все нечетные биты и сместим вправо, сделав четными
            return evenPart | oddPart; //склеим
            //т.е. решение
            //return (((x & 0xaaaaaaa) >> 1) | ((x & 0x55555555) << 1))
        }
    }
}
