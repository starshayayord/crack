namespace Yord.Crack.Begin.LeetCode
{
    // вернуть сумму диагоналей квадратной матрицы. Числа два раза не учитывать
    public class Task1572
    {
        public static int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            int l = mat.Length;
            for (int i = 0; i < l; i++)
            {
                sum += mat[i][i] + mat[i][l - i - 1];
            }

            // если матрица нечетная, то центр учли дважды, надо его вычесть
            return l % 2 == 1 ? sum - mat[l / 2][l / 2] : sum;
        }
        
        public static int DiagonalSum_2(int[][] mat) {
            int sum = 0;
            int l = mat.Length;
            for (int i = 0; i < l; i++)
            {
                sum += mat[i][i];
                int j = l - i -1;
                if (j != i)
                {
                    sum += mat[i][j];
                }
            }
            return sum;
        }
    }
}
