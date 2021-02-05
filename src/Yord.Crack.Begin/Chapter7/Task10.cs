using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Сапер.
    // Поле NxN, расставлено B мин. Соседние ячейки пусты или в них число мин в окружающих 8ми ячейках
    // Игрок открывает ячейку, если мина, то проигрыш. Если ячейка с числом, то игрок видит его. 
    // Если ячейка пуста, то открываются все соседние пустые(до окружа.щих с цифрами)
    // Победа, если открыты все ячейки, не содержащие мин.
    // Игрок может помечать ячейки как потенциальные мины
    public class Task10
    {
        public class Game
        {
            public enum GameState
            {
                Won,
                Lost,
                Running
            }

            private Board _board;
            private readonly int _rows;
            private readonly int _columns;
            private readonly int _bombs;
            private GameState _state;

            public GameState State => _state;

            public Game(int r, int c, int b)
            {
                _rows = r;
                _columns = c;
                _bombs = b;
                _state = GameState.Running;
            }

            public void Start()
            {
                _board ??= new Board(_rows, _columns, _bombs);
            }
            
            public void Turn(UserPlay play)
            {
                var turnResult = _board.PlayFlip(play);
                if (turnResult.IsSuccessfulMove)
                {
                    _state = turnResult.ResultingState;
                }
            }
        }

        public class Board
        {
            private readonly int _nRows;
            private readonly int _nColumns;
            private readonly int _nBombs;
            private Cell[][] _cells;
            private Cell[] _bombs;
            private int _numExposedRemaining;

            private readonly int[][] _deltas =
            {
                new[] {-1, -1}, new[] {-1, 0}, new[] {-1, 1},
                new[] {0, -1}, new[] {0, 1},
                new[] {1, -1}, new[] {1, 0}, new[] {1, 1}
            };

            public Board(int r, int c, int b)
            {
                _nRows = r;
                _nColumns = c;
                _nBombs = b;
                InitializeBoard();
                ShuffleBoard();
                SetNumberedCells();
                _numExposedRemaining = r * c - b;
            }

            public UserPlayResult PlayFlip(UserPlay play)
            {
                var cell = GetCell(play);
                if (cell == null) // за границами
                {
                    return new UserPlayResult(false, Game.GameState.Running);
                }

                if (play.IsGuess)
                {
                    cell.ToggleGuess();
                    return new UserPlayResult(true, Game.GameState.Running);
                }

                var flipResult = FlipCell(cell);
                if (cell.IsBomb)
                {
                    return new UserPlayResult(flipResult, Game.GameState.Lost);
                }

                if (cell.IsBlank)
                {
                    ExpandBlank(cell);
                }

                return _numExposedRemaining == 0
                    ? new UserPlayResult(flipResult, Game.GameState.Won)
                    : new UserPlayResult(flipResult, Game.GameState.Running);
            }
            
            private void ExpandBlank(Cell cell)
            {
                //  рядом с пустой ячейкой находятся либо пустые, либо с номерами, то точно не с бомбами
                var toExplore = new Queue<Cell>();
                toExplore.Enqueue(cell);
                while (toExplore.Any())
                {
                    // саму эту ячейку уже флипнули и поняли, что пустая
                    var currentCell = toExplore.Dequeue();
                    foreach (var delta in _deltas)
                    {
                        var r = currentCell.Row + delta[0];
                        var c = currentCell.Column + delta[1];
                        if (IsInBounds(r, c))
                        {
                            var neighbour = _cells[r][c];
                            if (FlipCell(neighbour) && neighbour.IsBlank)
                            {
                                toExplore.Enqueue(neighbour);
                            }
                        }
                    }
                }
            }

            private Cell GetCell(UserPlay play)
            {
                return IsInBounds(play.Row, play.Column) ? _cells[play.Row][play.Column] : null;
            }
            
            private void InitializeBoard()
            {
                _cells = new Cell[_nRows][];
                _bombs = new Cell[_nBombs];
                var bCounter = _nBombs;
                for (var r = 0; r < _nRows; r++)
                {
                    _cells[r] = new Cell[_nColumns];
                    for (var c = 0; c < _nColumns; c++)
                    {
                        // чтобы много раз не попадать на бомбы при генерации случайного места под бомбу,
                        // расставим их подряд, а потом перемешаем игроеов поле
                        if (bCounter > 0)
                        {
                            var bomb = new Cell(r, c, isBomb: true);
                            _bombs[bCounter - _bombs.Length] = bomb;
                            _cells[r][c] = bomb;
                            bCounter--;
                        }
                        else
                        {
                            _cells[r][c] = new Cell(r, c);
                        }
                    }
                }
            }

            // Случайная расстановка: перебираем ячейки от 0 до N-1;
            // Для каждого индекса выбирается случайный и элементы меняются местами
            private void ShuffleBoard()
            {
                var nCells = _nColumns * _nRows;
                var random = new Random();
                for (var index1 = 0; index1 < nCells; index1++)
                {
                    var index2 = index1 + random.Next(nCells - index1);
                    if (index1 == index2) continue; // не меняем ячейку саму с собой
                    var r1 = index1 / _nColumns;
                    var c1 = (index1 - r1 * _nColumns) % _nColumns;
                    var cell1 = _cells[r1][c1];
                    var r2 = index2 / _nColumns;
                    var c2 = (index2 - r2 * _nColumns) % _nColumns;
                    var cell2 = _cells[r2][c2];

                    cell2.SetRowColumn(r1, c1);
                    _cells[r1][c1] = cell2;
                    cell1.SetRowColumn(r2, c2);
                    _cells[r2][c2] = cell1;
                }
            }

            // проще перебрать все бомбы, и инкрементить значения в окружающих ячейках, чем перебирать все ячейки
            private void SetNumberedCells()
            {
                foreach (var b in _bombs)
                {
                    var rb = b.Row;
                    var cb = b.Column;
                    foreach (var delta in _deltas)
                    {
                        var r = rb + delta[0];
                        var c = cb + delta[1];
                        if (IsInBounds(r, c) && !_cells[r][c].IsBomb)
                        {
                            _cells[r][c].IncrementNumber();
                        }
                    }
                }
            }

            private bool IsInBounds(int r, int c)
            {
                return r > 0 && r < _nRows && c > 0 && c < _nColumns;
            }

            // true, если успешно перевернули
            private bool FlipCell(Cell cell)
            {
                if (cell.IsExposed || cell.IsGuess) return false;
                cell.Flip();
                _numExposedRemaining--;
                return true;
            }
        }


        public class Cell
        {
            private int _row;
            private int _column;
            private readonly bool _isBomb;
            private int _number; // кол-во бомб в соседних 8 ячейках. Пустышка 0, бомба -1. Можно использовать enum.
            private bool _isExposed; // признак открытости
            private bool _isGuess; // признак пометки игроком

            public Cell(int r, int c, bool isBomb = false)
            {
                _row = r;
                _column = c;
                if (isBomb)
                {
                    _isBomb = true;
                    _number = -1;
                }
            }
            
            public void Flip()
            {
                _isExposed = true;
            }
            
            public void ToggleGuess()
            {
                if (!_isExposed)
                {
                    _isGuess = !_isGuess;
                }
            }

            public void IncrementNumber()
            {
                _number++;
            }

            public bool IsExposed => _isExposed;

            public bool IsGuess => _isGuess;

            public bool IsBomb => _isBomb;

            public bool IsBlank => _number == 0;

            public int Row => _row;

            public int Column => _column;

            public void SetRowColumn(int r, int c)
            {
                _row = r;
                _column = c;
            }
        }

        // ход пользователя
        public class UserPlay
        {
            private int _row;
            private int _column;
            private bool _isGuess;

            public UserPlay(int r, int c, bool isGuess)
            {
                _row = r;
                _column = c;
                _isGuess = isGuess;
            }

            public int Row => _row;

            public int Column => _column;

            public bool IsGuess => _isGuess;
        }

        // результат хода
        public class UserPlayResult
        {
            // успешен ли ход вообще
            private bool _successful;
            private Game.GameState _resultingState;

            public UserPlayResult(bool successful, Game.GameState state)
            {
                _successful = successful;
                _resultingState = state;
            }

            public bool IsSuccessfulMove => _successful;

            public Game.GameState ResultingState => _resultingState;
        }
    }
}
