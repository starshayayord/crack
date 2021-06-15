namespace Yord.Crack.Begin.LeetCode
{
    //вернуть среднее, без учета макс и мин (10^3 <= salary[i] <= 10^6)
    public class Task1491
    {
        public static double Average(int[] salary)
        {
            var min = 1000000;
            var max = 1000;
            var sum = 0;
            foreach (var s in salary)
            {
                if (s < min)
                {
                    min = s;
                }
                if (s > max)
                {
                    max = s;
                }

                sum += s;
            }

            return (double)(sum - min - max) / (salary.Length - 2);
        }
    }
}
