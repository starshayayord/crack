using System;

namespace Yord.Crack.Begin.Chapter3
{
    // из 1 одномерного массива реализовать 3 стека
    public class Task1
    {
        public class ArrStack<T>
        {
            private readonly T[] _baseArray;
            private int? _firstIndex;
            private int? _secondIndex;
            private int? _thirdIndex;

            public ArrStack()
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
