using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter8
{
    // Робот стоит в левом вернем углу сетки, может перемещаться вправо и вниз. Некоторые ячейки сетки заблокированы.
    // Найти маршрут от правого нижнего угла
    public class Task2
    {
        public static List<Point> FindWay(bool[][] grid)
        {
            var maxRow = grid.Length - 1;
            var maxColumn = grid[0].Length - 1;
            var path = new List<Point>();
            var cache = new Dictionary<Point, bool>();
            if (GetPath(grid, maxRow, maxColumn, path, cache))
            {
                return path;
            }

            return null;
        }
        
        

        private static bool GetPath(bool[][] grid, int row, int column, List<Point> path, Dictionary<Point, bool> cache)
        {
            if (row < 0 || column < 0 || !grid[row][column])
            {
                return false;
            }

            var point = new Point(row, column);
            if (cache.TryGetValue(point, out var result))
            {
                return result;
            }

            var success = false;
            var isTopLeft = row == 0 && column == 0;
            //  получаем дерево с двумя ветвями.
            // Сначала дерево рекурсивно растет глубже и глубже, пока не наткнется на 0.0
            // Тогда начинам подниматься по дереву обратно, и класть в path, если хоть одна ветвь вернула true
            if (isTopLeft || GetPath(grid, row, column - 1, path, cache) ||
                GetPath(grid, row - 1, column, path, cache))
            {
                path.Add(point);
                success = true;
            }

            cache.Add(point, success);
            return success;
        }

        public class Point
        {
            protected bool Equals(Point other)
            {
                return Row == other.Row && Column == other.Column;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != this.GetType()) return false;
                return Equals((Point) obj);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Row, Column);
            }

            public static bool operator ==(Point left, Point right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Point left, Point right)
            {
                return !Equals(left, right);
            }

            public Point(int r, int c)
            {
                Row = r;
                Column = c;
            }

            public int Row { get; }

            public int Column { get; }
        }

        public static List<Coordinate> FindWay2(int[][] grid)
        {
            var maxRow = grid.Length - 1;
            var maxColumn = grid[0].Length - 1;
            var cache = new HashSet<Coordinate>();
            var queue = new Queue<Coordinate>();
            queue.Enqueue(new Coordinate(maxRow, maxColumn, new List<Coordinate>
            {
                new Coordinate(maxRow, maxColumn)
            }));
            while (queue.Any())
            {
                var cur = queue.Dequeue();
                if (cur.Row == 0 && cur.Column == 0)
                {
                    cur.Path.Reverse();
                    return cur.Path;
                }

                // влево
                if (cur.Column - 1 >= 0 && grid[cur.Row][cur.Column - 1] != 0 &&
                    !cache.Contains(new Coordinate(cur.Row, cur.Column - 1)))
                {
                    var newPath = new List<Coordinate>(cur.Path);
                    newPath.Add(new Coordinate(cur.Row, cur.Column - 1));
                    queue.Enqueue(new Coordinate(cur.Row, cur.Column - 1, newPath));
                }

                // вверх
                if (cur.Row - 1 >= 0 && grid[cur.Row - 1][cur.Column] != 0 &&
                    !cache.Contains(new Coordinate(cur.Row - 1, cur.Column)))
                {
                    var newPath = new List<Coordinate>(cur.Path);
                    newPath.Add(new Coordinate(cur.Row - 1, cur.Column));
                    queue.Enqueue(new Coordinate(cur.Row - 1, cur.Column, newPath));
                }
            }

            return null;
        }

        public class Coordinate
        {
            protected bool Equals(Coordinate other)
            {
                return Row == other.Row && Column == other.Column;
            }

            public List<Coordinate> Path { get; set; }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                return obj.GetType() == GetType() && Equals((Coordinate) obj);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Row, Column);
            }

            public static bool operator ==(Coordinate left, Coordinate right)
            {
                return Equals(left, right);
            }

            public static bool operator !=(Coordinate left, Coordinate right)
            {
                return !Equals(left, right);
            }

            public Coordinate(int r, int c, List<Coordinate> path = null)
            {
                Row = r;
                Column = c;
                Path = path;
            }

            public int Row { get; }

            public int Column { get; }
        }
    }
}
