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
        public enum GameState
        {
            Won,
            Lost,
            Running
        }
        
        public class Game
        {
            private int _nRows;
            private int _nColumns;
            private int _nBombs;
            private Board _board;
            private GameState _gameState;

            public GameState GameState => _gameState;
            public int Unexposed => _board.Unexposed;

            public Game(int nRows, int nColumns, int nBombs)
            {
                _nRows = nRows;
                _nColumns = nColumns;
                _nBombs = nBombs;
                _gameState = GameState.Running;
            }

            public void Start()
            {
                _board ??= new Board(_nRows, _nColumns, _nBombs);
                PrintGameState();
            }

            public void Play()
            {
                while (_gameState == GameState.Running)
                {
                    var input = Console.ReadLine();
                    var turn = Turn.Parse(input);
                    if (turn == null)
                    {
                        continue;
                    }

                    var r = _board.Play(turn);
                    if (r.IsSuccessfulMove)
                    {
                        _gameState = r.State;
                        PrintGameState();
                    }
                }
            }

            // тестовый метод. возвращает true, если бомба
            public bool Play(string input)
            {
                var turn = Turn.Parse(input);
                if (turn == null)
                {
                    return false;
                }

                var r = _board.Play(turn);
                if (r.IsSuccessfulMove)
                {
                    _gameState = r.State;
                    PrintGameState();
                    if (_gameState == GameState.Lost)
                    {
                        return true;
                    }
                }

                return false;
            }

            private void PrintGameState()
            {
                Console.WriteLine($"STATE: {_gameState}");
                _board.Print();
                Console.WriteLine("_____________________________");
            }
        }

        public class Board
        {
            private int _nRows;
            private int _nColumns;
            private int _nBombs;
            private Cell[][] _cells;
            private Cell[] _bombs;
            private int _nUnexposed;

            public int Unexposed => _nUnexposed;

            private readonly int[][] _deltas = { // 8 окружающих клеток
                new[] {-1, -1}, new[]{-1, 0}, new[]{-1, 1},
                new[]{ 0, -1},                new[]{ 0, 1},
                new[]{ 1, -1},  new[]{ 1, 0}, new[]{ 1, 1}
            };

            public Board(int nRows, int nColumns, int nBombs)
            {
                _nRows = nRows;
                _nColumns = nColumns;
                _nBombs = nBombs;
                _nUnexposed = nRows * nColumns - nBombs;
                Initialize();
                Shuffle();
                SetNumbers();
            }

            // сначала расположим бомбы подряд
            private void Initialize()
            {
                _cells = new Cell[_nRows][];
                _bombs = new Cell[_nBombs];
                var bombCounter = 0;
                for (var r = 0; r < _nRows; r++)
                {
                    _cells[r] = new Cell[_nColumns];
                    for (var c = 0; c < _nColumns; c++)
                    {
                        var isBomb = bombCounter < _nBombs;
                        var cell = new Cell(r, c, isBomb);
                        if (isBomb)
                        {
                            _bombs[bombCounter] = cell;
                            bombCounter++;
                        }

                        _cells[r][c] = cell;
                    }
                }
            }
            
            //затем перемешаем бомбы
            private void Shuffle()
            {
                var random = new Random();
                var nCells = _nRows * _nColumns;
                for (var index1 = 0; index1 < nCells; index1++)
                {
                    var index2 = index1 + random.Next(nCells - index1);
                    if (index1 != index2)
                    {
                        var r1 = index1 / _nColumns;
                        var c1 = (index1 - r1 * _nColumns) % _nColumns;
                        var cell1 = _cells[r1][c1];
                        
                        var r2 = index2 / _nColumns;
                        var c2 = (index2 - r1 * _nColumns) % _nColumns;
                        var cell2 = _cells[r2][c2];
                        
                        cell1.SetRowColumn(r2, c2);
                        _cells[r2][c2] = cell2;
                        cell2.SetRowColumn(r1, c1);
                        _cells[r1][c1] = cell2;
                    }
                }
                    
            }
            
            //установим цифры на клетки рядом с бомбами
            private void SetNumbers()
            {
                foreach (var bomb in _bombs)
                {
                    foreach (var d in _deltas)
                    {
                        var r = bomb.Row + d[0];
                        var c = bomb.Column + d[1];
                        if (IsInBounds(r, c))
                        {
                            _cells[r][c].IncrementNumber();
                        }
                    }
                }
            }
            
            private bool IsInBounds(int row, int column)
            {
                return row >= 0 && row < _nRows && column >= 0 && column < _nColumns;
            }

            public TurnResult Play(Turn turn)
            {
                var cell = GetCell(turn);
                if (cell == null) return new TurnResult(GameState.Running, false);
                if (turn.IsGuess)
                {
                    cell.ToggleGuess();
                    return new TurnResult(GameState.Running, true);
                }
                if (!TryFlipCell(cell)) return new TurnResult(GameState.Running, false);
                if(cell.IsBomb) return new TurnResult(GameState.Lost, true);
                if (cell.IsBlank)
                {
                    ExposeBlank(cell);
                }
                return new TurnResult(_nUnexposed == 0? GameState.Won : GameState.Running, true);
            }

            private void ExposeBlank(Cell cell)
            {
                var toExplore = new Queue<Cell>();
                toExplore.Enqueue(cell);// уже перевернули ранее в TryFlipCell, она пустая
                while (toExplore.Any())
                {
                    var currentCell = toExplore.Dequeue();// уже перевернутая ранее
                    foreach (var d in _deltas) // рекурсивно проверяем соседей на пустоту и переворачиваем
                    {
                        var r = currentCell.Row + d[0];
                        var c = currentCell.Column + d[1];
                        if (IsInBounds(r, c))
                        {
                            var neighbour = _cells[r][c];
                            if (TryFlipCell(neighbour) && neighbour.IsBlank) // перевернули соседа 
                            {
                                toExplore.Enqueue(neighbour); //  если пустой, то проверить соседние
                            }
                        }
                    }
                }
            }

            private bool TryFlipCell(Cell cell)
            {
                if (cell.IsExposed || cell.IsGuess) return false;
                cell.Flip();
                if (!cell.IsBomb)
                {
                    _nUnexposed--;
                }

                return true;
            }

            private Cell GetCell(Turn turn)
            {
                return !IsInBounds(turn.Row, turn.Row) ? null : _cells[turn.Row][turn.Column];
            }

            public void Print()
            {
                Console.WriteLine("   ");
                for (var c = 0; c < _nColumns; c++) 
                {
                    Console.Write(c + " ");
                }

                Console.WriteLine();
                for (var c = 0; c < _nColumns; c++) 
                {
                    Console.Write("--");
                }		
                Console.WriteLine();
                for (var r = 0; r < _nRows; r++) {
                    Console.Write(r + "| ");
                    for (var c = 0; c < _nColumns; c++) {
                            Console.Write(_cells[r][c].Print());
                    }
                    Console.WriteLine();
                }
            }
        }

        public class Cell
        {
            private int _row;
            private int _column;
            private int _number;
            private bool _isGuess;
            private bool _isBomb;
            private bool _isExposed;

            public Cell(int row, int column, bool isBomb)
            {
                _row = row;
                _column = column;
                if (isBomb)
                {
                    _isBomb = true;
                    _number = -1;
                }
                
            }

            public void ToggleGuess()
            {
                _isGuess = !_isGuess;
            }

            public bool Flip()
            {
                _isExposed = true;
                return _isBomb;
            }
            
            public int Row => _row;

            public int Column => _column;

            public bool IsBlank => _number == 0;

            public bool IsBomb => _isBomb;

            public bool IsGuess => _isGuess;

            public bool IsExposed => _isExposed;

            public void SetRowColumn(int r, int c)
            {
                _row = r;
                _column = c;
            }

            public void IncrementNumber()
            {
                _number++;
            }

            public string Print()
            {
                if (!_isExposed) return _isGuess ? "B" : "?";
                if (_isBomb) return "*";
                return IsBlank ? " " : $"{_number.ToString()}";

            }
        }

        public class Turn
        {
            private int _row;
            private int _column;
            private bool _isGuess;

            private Turn(int row, int column, bool isGuess)
            {
                _row = row;
                _column = column;
                _isGuess = isGuess;
            }

            public static Turn Parse(string input)
            {
                if (string.IsNullOrEmpty(input)) return null;
                var guess = false;
                if (input[0] == 'B')
                {
                    guess = true;
                    input = input.Substring(1);
                }
                var parts = input.Split(" ");
                if (parts.Length == 2 && int.TryParse(parts[0], out var r) && int.TryParse(parts[1], out var c))
                {
                    return new Turn(r, c, guess);
                }

                return null;
            }

            public int Row => _row;

            public int Column => _column;

            public bool IsGuess => _isGuess;
        }

        public class TurnResult
        {
            private GameState _state;

            private bool _isSuccessful;

            public TurnResult(GameState state, bool isSuccessful)
            {
                _state = state;
                _isSuccessful = isSuccessful;
            }

            public bool IsSuccessfulMove => _isSuccessful;

            public GameState State => _state;
        }
    }
}
