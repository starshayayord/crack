namespace Yord.Crack.Begin.LeetCode
{
    // Робот из точки (0,0) идет по 2D сетке. Если он заканчивает в (0,0), значит true.
    // Команды:R (right), L (left), U (up), and D (down)
    //
    public class Task657
    {
        public static bool JudgeCircle(string moves)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i< moves.Length; i++)
            {
                switch (moves[i])
                {
                    case 'R': x++;
                        break;
                    case 'L': x--;
                        break;
                    case 'U': y++;
                        break;
                    case 'D': y--;
                        break;
                }
            }

            return x == 0 && y == 0;
        }
    }
}
