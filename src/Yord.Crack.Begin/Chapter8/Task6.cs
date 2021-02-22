using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter8
{
    // Есть 3 башни и N дисков разного размера, которые могут перекладыаться между башнями
    // В начале диски отсортированы по возрастанию размера (каждый лежит на диске большего размера)
    // За раз можно переменстить 1 диск на вершину другой башни.
    // Нельзя класть диск на диск меньшего размера.
    // Написать прорамму для перемещения дисков с первой на последнюю башню с использованием стеков
    public class Task6
    {
        public static Tower MoveDisks(int n)
        {
            var sourceTower = new Tower(1, n);
            var resultTower = new Tower(3);
            var bufferTower = new Tower(2);
            MoveNDisks(n, sourceTower, resultTower, bufferTower);
            return resultTower;
        }

        // 1 диск: перемещаем 0 верхних на буфер, потом оставшийся 1 на результат, 0 с буфера на результат
        // 2 диска: перемещаем 1 верхний на буфер, потом оставшийся 1 на результат, 1 с буфера на результат
        // 3 диска: перемещаем 2 верхних на буфер, потом оставшийся 1 на результат, 2 с буфера на результат
        // 4 диска: перемещаем 3 верхних на буфер, потом оставшийся 1 на результат, 3 с буфера на результат
        // Пример:
        // 3 диска: перемещаем 2 верхних на буфер, потом оставшийся 1 на результат, 2 с буфера на результат
        // 2 верхних c (1) на буфер: 1 (1) -> (3) теперь это буфер, 1 (1) -> (2), (3) -> (2)
        // оставшийся 1 на результат: 1 (1) -> (3)
        // 2 с буфера на результат: 1 (2) -> (1), 1 (2) -> (3), 1 (1) -> (3)

        private static void MoveNDisks(int n, Tower source, Tower result, Tower buffer)
        {
            if (n == 0) 
                return; // нечего перемещать
            // переместить все верхние диски, кроме одного на буфер
            MoveNDisks(n - 1, source, buffer, result);
            // переместить нижний диск на результирующую башню, создав основание
            MoveTopDisk(source, result);
            // переместить все оставшиеся диски с буфера на результат
            MoveNDisks(n - 1, buffer, result, source);
        }

        private static void MoveTopDisk(Tower from, Tower to)
        {
            var disk = from.RemoveFromTop();
            to.PlaceOnTop(disk);
        }

        public class Tower
        {
            public Stack<int> _tower { get; }
            private readonly int Number;

            public Tower(int number, int n = 0)
            {
                _tower = new Stack<int>();
                Number = number;
                for (var diskSize = n; diskSize > 0; diskSize--)
                {
                    _tower.Push(diskSize);
                }
            }

            public int RemoveFromTop()
            {
                return _tower.Pop();
            }

            public void PlaceOnTop(int diskSize)
            {
                // диски уникальны
                if (_tower.Count > 0 && _tower.Peek() < diskSize)
                {
                    return;
                }

                _tower.Push(diskSize);
            }
        }
    }
}
