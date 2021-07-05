using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task999
    {
        public static int NumRookCaptures(char[][] board)
        {
            //идем, пока не нашли нужную нам фигуру.
            //Нашли - пошли от нее в 4 стороны.
            //Нашли B - блок, вышли за границы - блок.
            //нашли пешку +1 ход
            for (var i = 0; i < board.Length; ++i)
            {
                for (var j = 0; j < board[i].Length; ++j)
                {
                    if (board[i][j] == 'R')
                    {
                        return Capture(board, i, j, 0, 1) +
                               Capture(board, i, j, 0, -1) +
                               Capture(board, i, j, 1, 0) +
                               Capture(board, i, j, -1, 0);
                    }
                }
            }

            return 0;
        }

        public static int Capture(char[][] board, int x, int y, int dx, int dy)
        {
            while (x >= 0 && x < 8 && y >= 0 && y < 8 && board[x][y] != 'B')
            {
                if (board[x][y] == 'p')
                {
                    return 1;
                }

                x += dx;
                y += dy;
            }

            return 0;
        }
    }
}
