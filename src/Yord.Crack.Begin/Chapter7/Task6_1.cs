using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Пазл NxN фрагментов.
    // Существует метод bool FitsWith, возвращающий true, если два фрагмента должны располагаться рядом
    public class Task6_1
    {
        public class Puzzle
        {
            private LinkedList<Piece> _pieces; //неразложенные фрагменты
            private Piece[][] _solution;
            private int _size;

            public Puzzle(LinkedList<Piece> pieces, int size)
            {
                _size = size;
                _pieces = pieces;
                _solution = new Piece[_size][];
                for (var i = 0; i < size; i++)
                {
                    _solution[i] = new Piece[_size];
                }
            }


            public bool Solve()
            {
                var cornerPieces = new LinkedList<Piece>();
                var borderPieces = new LinkedList<Piece>();
                var innerPieces = new LinkedList<Piece>();
                // группируем кусочки по назначению
                GroupPieces(cornerPieces, borderPieces, innerPieces);
                for (var row = 0; row < _size; row++)
                {
                    for (var column = 0; column < _size; column++)
                    {
                        var pieces = GetGroupToSearch(cornerPieces, borderPieces, innerPieces, row, column);
                        if (pieces.Any()) return false; // нет кусочков, среди которых искать => нет решения
                        // сначала ставим левый верхний угол
                        Piece foundPiece;
                        if (row == 0 && column == 0)
                        {
                            foundPiece = GetOrientTopLeftPiece(pieces);
                        }
                        else
                        {
                            foundPiece = GetNextOrientedPiece(pieces, row, column);
                        }

                        // если не нашли следующий кусочек, значит решения нет
                        if (foundPiece == null)
                        {
                            return false;
                        }

                        //удаляем найденный кусочек из кучки и ставим в решение
                        pieces.Remove(foundPiece);
                        _solution[row][column] = foundPiece;
                    }
                }

                return true;
            }


            private void GroupPieces(LinkedList<Piece> corners, LinkedList<Piece> borders, LinkedList<Piece> inner)
            {
                foreach (var piece in _pieces)
                {
                    if (piece.IsCorner())
                    {
                        corners.AddFirst(piece);
                    }
                    else
                    {
                        if (piece.IsBorder())
                        {
                            borders.AddFirst(piece);
                        }
                        else
                        {
                            inner.AddFirst(piece);
                        }
                    }
                }
            }

            //  определяем, в какой кучке нужно искать
            private LinkedList<Piece> GetGroupToSearch(LinkedList<Piece> corners, LinkedList<Piece> borders,
                LinkedList<Piece> inner, int row, int column)
            {
                if (IsOnBorder(row) && IsOnBorder(column))
                {
                    return corners;
                }

                if (IsOnBorder(row) || IsOnBorder(column))
                {
                    return borders;
                }

                return inner;
            }
            
            private Edge GetMatchingEdge(Edge targetEdge, LinkedList<Piece> pieces)
            {
                return pieces
                    .Select(piece => piece.GetMatchingEdge(targetEdge))
                    .FirstOrDefault(matchingEdge => matchingEdge != null);
            }

            private bool IsOnBorder(int location)
            {
                return location == 0 || location == _size - 1;
            }

            private Piece GetOrientTopLeftPiece(LinkedList<Piece> pieces)
            {
                var piece = pieces.FirstOrDefault();
                if (piece == null || !piece.IsCorner())
                {
                    return null;
                }

                var orientations = GetValues<Orientation>();
                for (var i = 0; i < orientations.Length; i++)
                {
                    var currentEdge = piece.GetEdgeByOrientation(orientations[i]);
                    if (currentEdge.IsFlat)
                    {
                        var nextEdge = piece.GetEdgeByOrientation(orientations[(i + 1) % orientations.Length]);
                        if (nextEdge.IsFlat)
                        {
                            currentEdge.Orient(Orientation.Left);
                        }
                    }
                }

                return piece;
            }
            
            private Piece GetNextOrientedPiece(LinkedList<Piece> pieces, int row, int column)
            {
                // Если нужно найти первый кусочек в ряду,
                // то ищем край, подходящий под нижний край верхнего кусочка
                // иначе - под правый край предыдущего
                var orientationToMatch = column == 0 ? Orientation.Bottom : Orientation.Right;
                var targetEdge = column == 0
                    ? _solution[row - 1][column].GetEdgeByOrientation(orientationToMatch)
                    : _solution[row][column - 1].GetEdgeByOrientation(orientationToMatch);
                var foundEdge = GetMatchingEdge(targetEdge, pieces);
                // найденный край должен быть ориентирован противоположно искомому
                foundEdge?.Orient(orientationToMatch.GetOpposite());
                return foundEdge?.ParentPiece;
            }
        }

        public class Piece
        {
            private const int NumberOfEdges = 4;

            //привязываем ориентацию к кусочку, чтобы было легче крутить:
            //не придется менять свойство Shape соседних граней
            private Dictionary<Orientation, Edge> _edges = new Dictionary<Orientation, Edge>();

            public Piece(Edge[] edges)
            {
                var orientations = GetValues<Orientation>();
                for (var i = 0; i < orientations.Length; i++)
                {
                    edges[i].SetParentPiece(this);
                    _edges.Add(orientations[i], edges[i]);
                }
            }

            public bool IsCorner()
            {
                var orientations = GetValues<Orientation>();
                for (var i = 0; i < orientations.Length; i++)
                {
                    var currentEdge = _edges[orientations[i]];
                    if (currentEdge.IsFlat)
                    {
                        var nextEdge = _edges[orientations[(i + 1) % NumberOfEdges]];
                        if (nextEdge.IsFlat)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            public bool IsBorder()
            {
                return _edges.Values.Any(edge => edge.IsFlat);
            }

            public Edge GetEdgeByOrientation(Orientation orientation)
            {
                return _edges[orientation];
            }

            public Edge GetMatchingEdge(Edge targetEdge)
            {
                return _edges.Values.FirstOrDefault(edge => edge.IsFit(targetEdge));
            }

            public void OrientEdge(Edge edge, Orientation orientation)
            {
                var currentOrientation = _edges.First(kvp => kvp.Value == edge).Key;
                var timesToRotate = orientation - currentOrientation;
                if (timesToRotate < 0)
                {
                    timesToRotate += NumberOfEdges;
                }
                var orientations = GetValues<Orientation>();
                var rotatedEdges = new Dictionary<Orientation, Edge>();
                for (var i = 0; i < orientations.Length; i++)
                {
                    var oldOrientation = orientations[i];
                    var newOrientation = orientations[(i + timesToRotate) % NumberOfEdges];
                    rotatedEdges.Add(newOrientation, _edges[oldOrientation]);
                }

                _edges = rotatedEdges;
            }
        }

        public class Edge
        {
            private Piece _parentPiece;
            private Shape _shape;
            private string _code;
            public Piece ParentPiece => _parentPiece;
            public string Code => _code;

            public Edge(Shape shape, string code)
            {
                _shape = shape;
                _code = code;
            }

            public void SetParentPiece(Piece piece)
            {
                _parentPiece = piece;
            }

            public bool IsFit(Edge edge)
            {
                return edge.Code == _code;
            }

            public void Orient(Orientation orientation)
            {
                _parentPiece.OrientEdge(this, orientation);
            }

            public bool IsFlat => _shape == Shape.Flat;
        }

        public enum Shape
        {
            Inner,
            Outer,
            Flat
        }

        public enum Orientation
        {
            Left,
            Top,
            Right,
            Bottom
        }

        private static T[] GetValues<T>() where T : Enum
        {
            return (T[]) Enum.GetValues(typeof(T));
        }
    }


    public static class PuzzleExtensions
    {
        public static Task6_1.Orientation GetOpposite(this Task6_1.Orientation orientation)
        {
            return orientation switch
            {
                Task6_1.Orientation.Left => Task6_1.Orientation.Right,
                Task6_1.Orientation.Top => Task6_1.Orientation.Bottom,
                Task6_1.Orientation.Right => Task6_1.Orientation.Left,
                Task6_1.Orientation.Bottom => Task6_1.Orientation.Top,
                _ => throw new ArgumentOutOfRangeException(nameof(orientation))
            };
        }
    }
}
