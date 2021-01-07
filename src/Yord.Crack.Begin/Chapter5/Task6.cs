namespace Yord.Crack.Begin.Chapter5
{
    // Определить кол-во битов, которое необходимо изменить, чтоб получить из целого числа А целое число Б 
    public class Task6
    {
        public static int CountDifferentBits(int a, int b)
        {
            var counter = 0;

            //A XOR B получает единицы там, где биты разные
            //c &= c - 1 сбрасывает младший ненулевой бит числа С
            for (var c = a ^ b; c != 0; c &= c - 1)
            {
                counter++;
            }
            return counter;
        }
    }
}
