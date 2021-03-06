namespace Yord.Crack.Begin.LeetCode
{
    //Байкер стартует с точки 0 с высотой 0, проходит по n+1 точкам. Дан массив чистых приростов высоты.
    //Вернуть наибольшую высоту за время пути.
    public class Task1732
    {
        public static int LargestAltitude(int[] gain)
        {
            int h = 0;
            int m = 0;
            foreach (var d in gain)
            {
                h += d;
                if (h > m)
                {
                    m = h;
                }
            }

            return m;
        }
    }
}
