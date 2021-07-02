namespace Yord.Crack.Begin.LeetCode
{
    public class Task1719
    {
        public static int FindCenter(int[][] edges)
        {


            return edges[0][0] == edges[1][0] || edges[0][0] == edges[1][1]
                ? edges[0][0]
                : edges[0][1];

        }
    }
}
