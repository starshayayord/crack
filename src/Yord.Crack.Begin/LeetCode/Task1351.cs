namespace Yord.Crack.Begin.LeetCode
{
    // вернуть кол-во отрицательных чисел в матрице, которая отсортирована по убыванию с строках и столбцах
    public class Task1351
    {
        public static int CountNegatives(int[][] grid)
        {
            int neg = 0;
            int rmax = grid.Length;
            int cmax = grid[0].Length;
            for (int r = 0; r < rmax;r++)
            {
                for (int c = 0; c < cmax; c++)
                {
                    if (grid[r][c] < 0)
                    {
                        if (c == 0)
                        {
                            //cut all bottom rows
                            neg += (rmax - r) * cmax;
                            return neg;
                        }

                        
                        neg += (rmax - r) * (cmax-c);
                        //cut columns on the right
                        cmax = c;
                        break;

                    }
                }
            }

            return neg;
        }

        public static int CountNegatives_BS(int[][] grid)
        {
            int neg = 0;
            int rmax = grid.Length;
            int cmax = grid[0].Length;
            for (int r = 0; r < rmax;r++)
            {
                if (grid[r][0] < 0)
                {
                    //cut all bottom rows
                    neg += (rmax - r) * cmax;
                    return neg;
                }
                if (grid[r][cmax-1] >= 0)
                {
                    //skip positive row
                    continue;
                }
                
                int s = 0;
                int e = cmax;
                while (s <= e)
                {
                    int m = s + (e - s)/2;
                    if (grid[r][m] < 0)
                    {
                        e = m - 1;
                    }
                    else
                    {
                        s = m + 1;
                    }
                }
                neg += (rmax - r) * (cmax-s);
                cmax = s;
            }

            return neg;
        }
        
    }
}
