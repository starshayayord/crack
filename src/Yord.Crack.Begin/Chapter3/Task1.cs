using System;
using System.Linq;

namespace Yord.Crack.Begin.Chapter3
{
    // из 1 одномерного массива реализовать 3 стека
    public class Task1
    {
        // PERFECT
        // эффективное использование пространства массива
        // массив как бы закольцован, т.е. стек может начинаться в конце массива и заканчиваться в начале
        // поэтому есть метод получения абсолютного индекса в _values;
        public class ArrStack<T>
        {
            private T[] _values;
            private StackInfo[] _stacksInfo;

            public ArrStack(int defaultSize, int stacksAmount)
            {
                _values = new T[defaultSize * stacksAmount];
                _stacksInfo = new StackInfo[stacksAmount];
                for (var i = 0; i < stacksAmount; i++)
                {
                    _stacksInfo[i] = new StackInfo(defaultSize * i, defaultSize);
                }
            }

            public void Push(int stackNumber, T value)
            {
                //если все стеки уже полные
                if (_stacksInfo.Sum(s => s._size) == _values.Length) throw new IndexOutOfRangeException();

                var stackInfo = _stacksInfo[stackNumber];
                //расширяем стек, если он заполнен
                if (stackInfo.IsFull())
                {
                    Expand(stackNumber);
                }

                stackInfo._size++;
                _values[GetAbsIndex(stackInfo.LastElementIndex)] = value;
            }

            public T Pop(int stackNumber)
            {
                var stackInfo = _stacksInfo[stackNumber];
                if (stackInfo.IsEmpty) throw new IndexOutOfRangeException();
                var index = GetAbsIndex(stackInfo.LastElementIndex);
                var value = _values[index];
                _values[index] = default;
                stackInfo._size--;
                return value;
            }

            public T Peek(int stackNumber)
            {
                var stackInfo = _stacksInfo[stackNumber];
                return _values[GetAbsIndex(stackInfo.LastElementIndex)];
            }

            public bool IsEmpty(int stackNumber)
            {
                return _stacksInfo[stackNumber]._size == 0;
            }

            // для хранения информации об одном стеке
            private class StackInfo
            {
                public int _startIndex;
                public int _capacity; //вместимость
                public int _size; //текуйщий размер

                public StackInfo(int startIndex, int capacity)
                {
                    _startIndex = startIndex;
                    _capacity = capacity;
                }

                public bool IsFull() => _size == _capacity;

                public bool IsEmpty => _size == 0;

                public int LastElementIndex => _startIndex + _size - 1;

                public int LastCapacityIndex => _startIndex + _capacity - 1;
            }

            //проверяем, лежит ли индекс в границах стека. Стек может продолжаться от начала массива
            private bool IsWithinStackCapacity(int index, int stackNumber)
            {
                if (index < 0 || index >= _values.Length)
                {
                    return false;
                }

                var stackInfo = _stacksInfo[stackNumber];
                // при циклическом переносе индекса вносим поправку
                // то есть например всего _values.Length = 6, _startIndex = 5, а _size = 3;
                // то есть stack занимает индексы [5],[0],[1]
                // в этом случае index[1] < stackInfo._startIndex[5] 
                // и необходимо сделать его поправку на длину массива, т.е. conIndex = [6] + [1] = [7]
                // если же брать индекс [5], то его conIndex так и останется [5]
                var conIndex = index < stackInfo._startIndex ? index + _values.Length : index;
                var end = stackInfo._startIndex + stackInfo._capacity;
                return stackInfo._startIndex <= conIndex && conIndex < end;
            }

            private void Expand(int stackNumber)
            {
                Shift((stackNumber + 1) % _stacksInfo.Length);
                _stacksInfo[stackNumber]._capacity++;
            }

            private void Shift(int stackNumber)
            {
                var stackInfo = _stacksInfo[stackNumber];
                //если этот стек заполнен, то двигаем следующий стек на 1 элемент
                // (если в следующем стеке места нет, то двигаем следующий и т. д.),
                // на них будем:
                // перемещать элементы на 1 ближе к концу, чистить бывший начальный элемент и урезать вместимость
                // (тем самым освободим бывший начальный элемент под конец стека предыдущего)
                if (stackInfo._size > stackInfo._capacity)
                {
                    var nextStackNumber = (stackNumber + 1) % _stacksInfo.Length;
                    Shift(nextStackNumber);
                    stackInfo._capacity++;
                }

                //берем индекс потенциально последнего элемента в стеке
                var index = GetAbsIndex(stackInfo.LastCapacityIndex);
                //и все элементы двигаем на 1 в сторону конца, освободив один индекс впереди
                while (IsWithinStackCapacity(index, stackNumber))
                {
                    var prevIndex = GetAbsIndex(index - 1);
                    _values[index] = _values[prevIndex];
                    index = prevIndex;
                }

                _values[stackInfo._startIndex] = default;
                stackInfo._startIndex = GetAbsIndex(index + 1);
                stackInfo._capacity--; //урезаем вместимость 
            }

            //получить индекс в диапазоне 0 -> _values.Length -1
            private int GetAbsIndex(int index)
            {
                var max = _values.Length;
                return (index % max + max) % max;
            }
        }

        //элементы из разных стеков располагаются: 1,1,1...,2,2,2...,3,3,3...
        //реализация приятнее, чем ArrStack1
        //если один стек намного длиннее других, то распределение свободного места неоптимально 
        public class ArrStack2<T>
        {
            private const int StackSize = 10;
            private readonly T[] _baseArray;
            private int[] _stackPointers = {-1, -1, -1};

            public ArrStack2()
            {
                _baseArray = new T[StackSize * 3];
            }

            public void Push(T value, int stackNumber)
            {
                if (_stackPointers[stackNumber] + 1 > StackSize) throw new IndexOutOfRangeException();
                _baseArray[GetIndex(stackNumber) + 1] = value;
                _stackPointers[stackNumber]++;
            }

            public T Pop(int stackNumber)
            {
                if (_stackPointers[stackNumber] == -1) throw new IndexOutOfRangeException();
                var value = _baseArray[GetIndex(stackNumber)];
                _baseArray[GetIndex(stackNumber)] = default;
                _stackPointers[stackNumber]--;
                return value;
            }

            public bool IsEmpty(int stackNumber)
            {
                return _stackPointers[stackNumber] == -1;
            }

            public T Peek(int stackNumber)
            {
                if (IsEmpty(stackNumber)) throw new IndexOutOfRangeException();
                return _baseArray[GetIndex(stackNumber)];
            }

            private int GetIndex(int stackNumber)
            {
                return stackNumber * StackSize + _stackPointers[stackNumber];
            }
        }

        //элементы из разных стеков располагаются: 1,2,3,1,2,3,1,2,3...
        //если один стек намного длиннее других, то распределение свободного места неоптимально   
        public class ArrStack1<T>
        {
            private readonly T[] _baseArray;
            private int? _firstIndex;
            private int? _secondIndex;
            private int? _thirdIndex;

            public ArrStack1()
            {
                _baseArray = new T[30];
            }

            public void Push(T v, int stackNumber)
            {
                var nextIndex = stackNumber switch
                {
                    1 => ToNext(ref _firstIndex, 0),
                    2 => ToNext(ref _secondIndex, 1),
                    _ => ToNext(ref _thirdIndex, 2)
                };

                _baseArray[nextIndex] = v;
            }

            public T Pop(int stackNumber)
            {
                T v = stackNumber switch
                {
                    1 => ToPrevious(ref _firstIndex, 0),
                    2 => ToPrevious(ref _secondIndex, 1),
                    _ => ToPrevious(ref _thirdIndex, 2)
                };

                return v;
            }

            private int ToNext(ref int? index, int startIndex)
            {
                var next = index + 3 ?? startIndex;
                index = next;
                return next;
            }

            private T ToPrevious(ref int? index, int startIndex)
            {
                if (index == null) throw new IndexOutOfRangeException();
                var v = _baseArray[index.Value];
                _baseArray[index.Value] = default;
                if (index == startIndex)
                {
                    index = null;
                }
                else
                {
                    index -= 3;
                }

                return v;
            }
        }
    }
}
