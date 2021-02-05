using System;
using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // generic класс-аналог массива с эффективной реализацией циклического сдвига.  Поддержать перебор
    public class Task9
    {
        public class CircularArray<T> : IEnumerable<T>
        {
            private readonly T[] _items;
            private int _head;

            public CircularArray(int size)
            {
                _items = new T[size];
            }

            public void Rotate(int shiftRight)
            {
                _head = Convert(shiftRight);
            }

            private T Get(int i)
            {
                if (i < 0 || i >= _items.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return _items[Convert(i)];
            }

            private void Set(int i, T value)
            {
                if (i < 0 || i >= _items.Length)
                {
                    throw new IndexOutOfRangeException();
                }

                _items[Convert(i)] = value;
            }
            
            public T this[int index]
            {
                get => Get(index);
                set => Set(index, value);
            }

            //функция преобразования индекса в сдвинутый
            private int Convert(int index)
            {
                //  если двигаем влево на Х (вправо на отрицательное число),
                // то на самом деле двигаем вправо на (Lenght - Х)
                if (index < 0)
                {
                    index += _items.Length;
                }

                // если двигаем больше, чем длина массива, то остается подвинуть на остаток от деления
                return (_head + index) % _items.Length;
            }

            public IEnumerator<T> GetEnumerator()
            {
                return new CircularArrayEnumerator(this);
            }

            private class CircularArrayEnumerator : IEnumerator<T>
            {
                // current - смещение от повернутого начала
                private int _current;
                private readonly int _head;
                private T[] _items;

                public CircularArrayEnumerator(CircularArray<T> ca)
                {
                    _items = ca._items;
                    _head = ca._head;
                    _current = -1;
                }
                public bool MoveNext()
                {
                    _current++;
                    return _current < _items.Length;
                }

                public void Reset()
                {
                    _current = -1;
                }

                public T Current => _items[(_head + _current) % _items.Length];

                object IEnumerator.Current => Current;

                public void Dispose()
                {
                    _items = null;
                }
            }

            
            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
