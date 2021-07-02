namespace Yord.Crack.Begin.LeetCode
{
    public class Task766
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            for (var r = 0; r < matrix.Length -1; r++)
            {
                for (var c = 0; c < matrix[0].Length - 1; c++)
                {
                    if (matrix[r][c] != matrix[r + 1][c + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
