using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Пазл NxN фрагментов.
    // Существует метод bool FitsWith, возвращающий true, если два фрагмента должны располагаться рядом

    public class Task6
    {
        // каждый кусочек имеет позицию Х, У и 4 стороны.
        // Сторона мб выпуклая, вогнутая, плоская.
        // Ориентация фрагмента мб: левая, правая, верняя, нижняя
        // в процессе сборки необходимо хранить позицию каждого фрагмента:
        // - абсолютная: (Х, Y)
        // - относительная: расположен где-то, но рядом с другими


        public class Puzzle // список фрагментов. Когда пазл собран, матрица NxN заполнена
        {
            private LinkedList<Piece> _pieces; // неразложенные фрагменты
            private Piece[][] _solution;
            private int _size;

            public Puzzle(int size, LinkedList<Piece> sourcePieces)
            {
                _pieces = sourcePieces;
                _size = size;
                _solution = new Piece[_size][];
                for (var i = 0; i < size; i++)
                {
                    _solution[i] = new Piece[_size];
                }
            }

            public void GroupPieces(LinkedList<Piece> cornerPieces, LinkedList<Piece> borderPieces,
                LinkedList<Piece> insidePieces)
            {
                foreach (var piece in _pieces)
                {
                    if (piece.IsCorner())
                    {
                        cornerPieces.AddFirst(piece);
                    }
                    else
                    {
                        if (piece.IsBorder())
                        {
                            borderPieces.AddFirst(piece);
                        }
                        else
                        {
                            insidePieces.AddFirst(piece);
                        }
                    }
                }
            }

            public void OrientTopLeftCornet(Piece piece)
            {
                if (!piece.IsCorner()) return;
                var orientations = (Orientation[]) Enum.GetValues(typeof(Orientation));
                for (var i = 0; i < orientations.Length; i++)
                {
                    var current = piece.GetEdgeWithOrientation(orientations[i]);
                    var next = piece.GetEdgeWithOrientation(orientations[(i + 1) % orientations.Length]);
                    if (current.Shape == Shape.Flat && next.Shape == Shape.Flat)
                    {
                        piece.SetEdgeAsOrientation(current, Orientation.Left);
                        return;
                    }
                }
            }


            // т.е. индекс 0 or (_size-1)
            public bool IsBorderIndex(int location)
            {
                return location == 0 || location == _size - 1;
            }

            // есть ли среди кусочков из списка такой, грань которого подходит к текущей грани 
            private Edge GetMatchingEdge(Edge targetEdge, LinkedList<Piece> pieces)
            {
                foreach (var piece in pieces)
                {
                    var matchingEdge = piece.GetMatchingEdge(targetEdge);
                    if (matchingEdge != null)
                    {
                        return matchingEdge;
                    }
                }

                return null;
            }

            private void SetEdgeInSolution(LinkedList<Piece> pieces, Edge edge, int row, int column,
                Orientation orientation)
            {
                var piece = edge.ParentPiece;
                piece.SetEdgeAsOrientation(edge, orientation);
                _pieces.Remove(piece);
                _solution[row][column] = piece;
            }

            //  вернуть кучку, в которой стоит искать кусочек для этого места
            private LinkedList<Piece> GetPiecesListToSearch(LinkedList<Piece> cornerPieces,
                LinkedList<Piece> borderPieces, LinkedList<Piece> insidePieces, int row, int column)
            {
                if (IsBorderIndex(row) && IsBorderIndex(column))
                {
                    return cornerPieces;
                }

                if (IsBorderIndex(row) || IsBorderIndex(column))
                {
                    return borderPieces;
                }

                return insidePieces;
            }

            private bool FitNextEdge(LinkedList<Piece> piecesToSearch, int row, int column)
            {
                if (row == 00 && column == 0)
                {
                    var p = piecesToSearch.First.Value;
                    piecesToSearch.RemoveFirst();
                    OrientTopLeftCornet(p);
                    _solution[0][0] = p;
                }
                else
                {
                    // если первый столбец, то надо найти пару для кусочка выше, иначе - слева
                    var pieceToMatch = column == 0 ? _solution[row - 1][0] : _solution[row][column - 1];
                    // если первый столбец, то надо найти пару для нижней части, иначе - для правой
                    var orientationToMatch = column == 0 ? Orientation.Bottom : Orientation.Right;
                    var edgeToMatch = pieceToMatch.GetEdgeWithOrientation(orientationToMatch);
                    var edge = GetMatchingEdge(edgeToMatch, piecesToSearch);
                    if (edge == null) return false; // невозможно решить пазл
                    var orientation = orientationToMatch.GetOpposite();
                    SetEdgeInSolution(piecesToSearch, edge, row, column, orientation.Value);
                }

                return true;
            }

            public bool Solve()
            {
                LinkedList<Piece> cornerPieces = new LinkedList<Piece>();
                LinkedList<Piece> borderPieces = new LinkedList<Piece>();
                LinkedList<Piece> insidePieces = new LinkedList<Piece>();
                GroupPieces(cornerPieces, borderPieces, insidePieces);
                for (var row = 0; row < _size; row++)
                {
                    for (var column = 0; column < _size; column++)
                    {
                        var piecesToSearch =
                            GetPiecesListToSearch(cornerPieces, borderPieces, insidePieces, row, column);
                        if (!FitNextEdge(piecesToSearch, row, column))
                        {
                            return false;
                        }
                    }
                }

                return true;
            }
        }

        public class Piece
        {
            private const int NumberOfEdges = 4;
            private Dictionary<Orientation, Edge> _edges = new Dictionary<Orientation, Edge>();

            public Piece(Edge[] edges)
            {
                var orientations = (Orientation[]) Enum.GetValues(typeof(Orientation));
                for (var i = 0; i < edges.Length; i++)
                {
                    var edge = edges[i];
                    edge.SetParentPiece(this);
                    _edges.Add(orientations[i], edge);
                }
            }

            // сменить ориентацию края (вертим столько раз, на сколько нужная ориентация отличается от текущей)
            public void SetEdgeAsOrientation(Edge edge, Orientation orientation)
            {
                var currentOrientation = GetOrientation(edge);
                RotateEdgesBy((int) orientation - (int) currentOrientation);
            }

            // получить текущую ориентауию края
            private Orientation? GetOrientation(Edge edge)
            {
                foreach (var (orientation, ed) in _edges)
                {
                    if (ed.Equals(edge))
                    {
                        return orientation;
                    }
                }

                return null;
            }

            // повернуть край N раз
            public void RotateEdgesBy(int numberRotations)
            {
                var orientations = (Orientation[]) Enum.GetValues(typeof(Orientation));
                var rotated = new Dictionary<Orientation, Edge>();
                numberRotations %= NumberOfEdges;
                if (numberRotations < 0)
                {
                    numberRotations += NumberOfEdges;
                }

                for (var i = 0; i < orientations.Length; i++)
                {
                    var oldOrientation = orientations[(i - numberRotations + NumberOfEdges) % NumberOfEdges];
                    var newOrientation = orientations[i];
                    rotated.Add(newOrientation, _edges[oldOrientation]);
                }

                _edges = rotated;
            }

            public bool IsCorner()
            {
                var orientations = (Orientation[]) Enum.GetValues(typeof(Orientation));
                for (var i = 0; i < orientations.Length; i++)
                {
                    var currentShape = _edges[orientations[i]].Shape;
                    if (currentShape == Shape.Flat)
                    {
                        var nextShape = _edges[orientations[(i + 1) % NumberOfEdges]].Shape;
                        if (nextShape == Shape.Flat)
                        {
                            return true;
                        }
                    }
                }

                return false;
            }

            public bool IsBorder()
            {
                var orientations = (Orientation[]) Enum.GetValues(typeof(Orientation));
                for (var i = 0; i < orientations.Length; i++)
                {
                    var currentShape = _edges[orientations[i]].Shape;
                    if (currentShape == Shape.Flat)
                    {
                        return true;
                    }
                }

                return false;
            }

            public Edge GetEdgeWithOrientation(Orientation orientation)
            {
                return _edges[orientation];
            }

            public Edge GetMatchingEdge(Edge targetEdge)
            {
                foreach (var (_, edge) in _edges)
                {
                    if (targetEdge.FitsWith(targetEdge))
                        return edge;
                }

                return null;
            }
        }

        public class Edge
        {
            private Shape _shape;
            private string _code; // how pieces fit together, mock of picture
            private Piece _parentPiece;

            public Shape Shape => _shape;
            public string Code => _code;
            public Piece ParentPiece => _parentPiece;


            public Edge(Shape shape, string code, Piece parentPiece)
            {
                _shape = shape;
                _code = code;
                _parentPiece = parentPiece;
            }

            public bool FitsWith(Edge edge)
            {
                return edge.Code.Equals(_code);
            }

            public void SetParentPiece(Piece piece)
            {
                _parentPiece = piece;
            }
        }
    }

    public enum Orientation
    {
        Left,
        Top,
        Right,
        Bottom
    }

    public enum Shape
    {
        Inner,
        Outer,
        Flat
    }

    public static class Extensions
    {
        public static Shape? GetOpposite(this Shape shape)
        {
            switch (shape)
            {
                case Shape.Inner:
                    return Shape.Outer;
                case Shape.Outer:
                    return Shape.Inner;
                default:
                    return null;
            }
        }

        public static Orientation? GetOpposite(this Orientation orientation)
        {
            switch (orientation)
            {
                case Orientation.Left:
                    return Orientation.Right;
                case Orientation.Top:
                    return Orientation.Bottom;
                case Orientation.Right:
                    return Orientation.Left;
                case Orientation.Bottom:
                    return Orientation.Top;
                default:
                    return null;
            }
        }
    }
}
