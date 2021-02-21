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
            var sourceTower = new Tower(1,n);
            var resultTower = new Tower(2);
            var bufferTower = new Tower(3);
            MoveTopNDisks(n, sourceTower, resultTower, bufferTower);
            return resultTower;
        }

        //  1 диск: перемещаем 0 верхних на буфер, потом оставшийся 1 на результат, 0 с буфера на результат
        // 2 диска: перемещаем 1 верхний на буфер, потом оставшийся 1 на результат, 1 с буфера на результат
        // 3 диска: перемещаем 2 верхних на буфер, потом оставшийся 1 на результат, 2 с буфера на результат
        // 4 диска: перемещаем 3 верхних на буфер, потом оставшийся 1 на результат, 3 с буфера на результат
        private static void MoveTopNDisks(int n, Tower source, Tower result, Tower buffer)
        {
            if (n == 0) 
                return; // нечего перемещать
            //переместить все верхние диски, кроме одного на буфер
            MoveTopNDisks(n - 1, source, buffer, result);
            //переместить нижний диск на результирующую башню, создав основание
            MoveTopDisk(source, result);
            // переместить все оставшиеся диски с буфера на результат
            MoveTopNDisks(n - 1, buffer, result, source);
        }

        private static void MoveTopDisk(Tower from, Tower to)
        {
            var disk = from.RemoveFromTop();
            to.PlaceOnTop(disk);
        }

        public class Tower
        {
            public Stack<int> _tower { get; set; }
            public bool IsEmpty => _tower.Count == 0;
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

            public bool PlaceOnTop(int diskSize)
            {
                // диски уникальны
                if (_tower.Count > 0 && _tower.Peek() < diskSize)
                {
                    return false;
                }

                _tower.Push(diskSize);
                return true;
            }
        }
    }
}
