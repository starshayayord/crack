namespace Yord.Crack.Begin.LeetCode
{
    //logs[i] = [birth, death), вернуть самый ранний год с макс популяцией, 1950 <= birthi < deathi <= 2050
    public class Task1854
    {
        public static int MaximumPopulation(int[][] logs)
        {
            var p = new int[102];

            foreach (var log in logs)
            {
                p[log[0] - 1950]++;
                p[log[1] - 1950]--;
            }

            var r = 0;
            for (int i = 1; i < p.Length; ++i)
            {
                p[i] += p[i - 1];
                r = p[i] > p[r] ? i : r;
            }

            return r + 1950;
        }
    }
}
