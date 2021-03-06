using System.Linq;

namespace Yord.Crack.Begin.Chapter7
{
    // Реверси.
    // Поле с фишками. Каждая фишка с одной стороны черная, с другой - белая.
    // Когда ряд фишек ограничен фишками противника (слева, справа или сверху и снизу), цвет фишек меняется на противоположный
    // При ходе игрок обязан захватить по крайней мере одну фишку противника, если это возможно
    // Игра заканчивается, когда у обоих игроков нет допустимых ходов.
    // Побеждает тот, чьих фишек больше на поле.
    public class Task8
    {
        // классы Game и Board позволяют организовать логическое разделение, однако увеличивают уровень абстракции.
        // текущий результат будем хранить в Board, т.к. оно логически группируется с состоянием доски.
        // Game синглтоном позволяет легко вызвать методы без ссылки на объект
        // Однако это значит, что в программе только один экземпляр Game, что мб минусом
        public class Game
        {
            private Player[] _players;
            private static Game _instance;
            private Board _board;
            private const int Rows = 10;
            private const int Columns = 10;

            private Game()
            {
                _board = new Board(Rows, Columns);
                _players = new Player[2];
                _players[0] = new Player(Color.Black);
                _players[1] = new Player(Color.White);
            }

            public static Game GetInstance()
            {
                return _instance ??= new Game();
            }

            public Board Board => _board;
        }

        public class Board
        {
            private int _blackCount;
            private int _whiteCount;
            private Piece[][] _board;

            public Board(int rows, int columns)
            {
                _board = new Piece[rows][];
                for (var i = 0; i < rows; i++)
                {
                    _board[i] = new Piece[columns];
                }
            }

            // инициализация начальной расстановки фишек (4 в центре)
            // WB
            // BW
            public void Initialize()
            {
                var middleRow = _board.Length / 2;
                var middleColumn = _board[middleRow].Length / 2;
                _board[middleRow][middleColumn] = new Piece(Color.White);
                _board[middleRow][middleColumn + 1] = new Piece(Color.Black);
                _board[middleRow + 1][middleColumn] = new Piece(Color.Black);
                _board[middleRow + 1][middleColumn + 1] = new Piece(Color.White);
                _blackCount = 2;
                _whiteCount = 2;
            }

            // попытка поместить фишку в позицию (row, column)
            public bool PlacePiece(int row, int column, Color color)
            {
                if (_board[row][column] != null)
                {
                    return false;
                }

                // После хода пытаемся перевернуть фишки противника в каждом доступном направлении
                var results = new int [4];
                results[0] = FlipSection(row - 1, column, color, Direction.Up);
                results[1] = FlipSection(row + 1, column, color, Direction.Down);
                results[2] = FlipSection(row, column+1, color, Direction.Right);
                results[3] = FlipSection(row, column-1, color, Direction.Left);
                var flipped = results.Where(r => r > 0).Sum();
                // не смогли ничего перевернуть
                if (flipped < 0)
                {
                    return false;
                }
                _board[row][column] = new Piece(color);
                UpdateScore(color, flipped+1);
                return true;
            }


            public int GetScore(Color color)
            {
                return color == Color.Black ? _blackCount : _whiteCount;
            }

            // Обновить доску дополнительными фишками newPieces цвета newColor
            // (уменьшаем кол-во фишек противоложного цвета)
            public void UpdateScore(Color newColor, int newPieces)
            {
                if (newColor == Color.Black)
                {
                    _blackCount += newPieces;
                    _whiteCount -= newPieces - 1;
                }
                else
                {
                    _whiteCount += newPieces;
                    _blackCount -= newPieces - 1;
                }
            }

            // Поменять цвет фишек от (row, column) в направлении direction
            private int FlipSection(int row, int column, Color color, Direction direction)
            {
                

                //  если переворачивать нечего - ошибка
                if (row < 0 || row >= _board.Length || column < 0 || column >= _board[row].Length ||
                    _board[row][column] == null)
                {
                    return -1;
                }
                
                var r = 0;
                var c = 0;
                // в каком направлении будем идти по доске
                switch (direction)
                {
                    case Direction.Left:
                        c = -1;
                        break;
                    case Direction.Right:
                        c = 1;
                        break;
                    case Direction.Up:
                        r =-1;
                        break;
                    case Direction.Down:
                        r = 1;
                        break;
                }

                // уже нужный цвет, нечего переворачивать дальше
                if (_board[row][column].Color == color)
                {
                    return 0;
                }

                // рекурсивно перевернем фишки в нужном направлении, пока можем
                // если мы не натолкнулись на наш цвет, значит мы дошли до границы или пустого места раньше
                // значит мы не окружили никаких фишек и переворачивать нечего
                // вернем -1
                var flipped = FlipSection(row + r, column + c, color, direction);
                if (flipped < 0)
                {
                    return -1;
                }
                // перевернем фишку, с которой начинали переворачивать все
                _board[row][column].Flip();
                return flipped + 1;
            }
        }

        public class Piece
        {
            private Color _color;

            public Piece(Color color)
            {
                _color = color;
            }

            public void Flip()
            {
                _color = _color == Color.Black ? Color.White : Color.Black;
            }

            public Color Color => _color;
        }

        public class Player
        {
            private Color _color;

            public Player(Color color)
            {
                _color = color;
            }

            public Color Color => _color;

            public int GetScore()
            {
                return Game.GetInstance().Board.GetScore(_color);
            }

            public bool PlayPiece(int row, int column)
            {
                return Game.GetInstance().Board.PlacePiece(row, column, _color);
            }
        }

        public enum Direction
        {
            Left,
            Right,
            Up,
            Down
        }

        public enum Color
        {
            Black,
            White
        }
    }
}
