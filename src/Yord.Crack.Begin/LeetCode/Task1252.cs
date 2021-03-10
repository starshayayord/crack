using System.Linq;
namespace Yord.Crack.Begin.LeetCode
{
    //нулевая матрица m^n. Дан массив [(строка, столбец)].
    //Каждый жлемент массивы инкрементит все элементы в соответтствующих строках, столбцах.
    //Вернуть кол-во нечетных элементов в матрице
    public class Task1252
    {
        public static int OddCells(int n, int m, int[][] indices)
        {
            var rows = new bool[n];
            var cols = new bool [m];
            foreach (var index in indices)
            {
                rows[index[0]] = !rows[index[0]];
                cols[index[1]] = !cols[index[1]];
            }

            //кол-во строк и столбцов, которые инкрементились нечетное кол-во раз, т.е. содержат неченые числа
            int oddRows = rows.Count(r => r);
            int oddCols = cols.Count(r => r);
            // кол-во нечетных строк*длину строки + кол-во нечетных столбцов* длину столбца 
            // если клетка находится и на нечетной строке и на нечетном столбце, то она инкрементилась на 2,
            // значит она четная, нужно ее вычесть.
            // Таких клеток столько, сколько нечетных строк * нечетные столбцов
            // (т.е. сколько раз нечетные стобцы пересекают нечетные строки);
            // Также мы дваждый учли эти клетки,т.к. сначала посчитали такие клетки в столбцах, а потом в строках,
            // значит вычитаем это число два раза
            return oddRows * m + oddCols * n - 2 * oddRows * oddCols;
        }
    }
}
