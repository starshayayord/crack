namespace Yord.Crack.Begin.LeetCode
{
    // 1-земля, 0 - вода. Клетки соединены только вертикально и горизонтально, есть 1 остров, без озер
    // Вычислить периметр острова
    public class Task463
    {
        public static int IslandPerimeter(int[][] grid)
        {
            //когда очень маленький остров в очень большой воде
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    // идем до первого кусочка острова, потом рекурсивно разворачиваемся от него
                    if (grid[i][j] == 1)
                    {
                        return GetPerimeter(grid, i, j);
                    }
                }
            }

            return 0;
        }


        private static int GetPerimeter(int[][] grid, int i, int j)
        {
            if (i < 0 || i > grid.Length - 1 || j < 0 || j > grid[0].Length - 1) return 1; //крайняя клетка
            if (grid[i][j] == 0) return 1; //достигли воды
            if (grid[i][j] == -1) return 0; //уже учли эту клетку
            int r = 0;
            grid[i][j] = -1; //пометили как посещенную
            r += GetPerimeter(grid, i - 1, j); // граница сверху
            r += GetPerimeter(grid, i + 1, j); // граница снизу
            r += GetPerimeter(grid, i, j - 1); // граница слева
            r += GetPerimeter(grid, i, j + 1); // граница справа
            return r;
        }

        public static int IslandPerimeter_Simple(int[][] grid)
        {
            int islands = 0;
            int neighbours = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        islands++;
                        //остров имеет соседа снизу, его границу снизу надо вычесть
                        if (i != grid.Length - 1 && grid[i + 1][j] == 1)
                        {
                            neighbours++;
                        }

                        // остров имеет соседа справа, правую границу нужно вычесть
                        if (j != grid[0].Length - 1 && grid[i][j + 1] == 1) neighbours++;
                    }
                }
            }

            //у каждого острова 4 стороны
            //у каждого соседа нужно вычесть их общие границы
            //например, есть два острова подряд, тогда neighbours=1, т.к. только левый остров имеет соседа справа 
            //но общую границу нужно вычесть у обоих островов, т.е. *2
            return islands * 4 - neighbours * 2;
        }

        public static int IslandPerimeter_2(int[][] grid)
        {
            int p = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    int up = i == 0 ? 0 : grid[i - 1][j];
                    int left = j == 0 ? 0 : grid[i][j - 1];
                    if (grid[i][j] != up) p++; //верхняя граница
                    if (grid[i][j] != left) p++; //левая граница
                    if (grid[i][j] > 0 && j == grid[0].Length - 1) p++; // правый край
                    if (grid[i][j] > 0 && i == grid.Length - 1) p++; // нижний край
                }
            }


            return p;
        }
    }
}
