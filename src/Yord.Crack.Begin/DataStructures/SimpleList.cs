using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Yord.Crack.Begin.DataStructures
{
    public class SimpleList<T> : ICollection
    {
        private T[] _items;
        private int _size;
        private object _syncRoot;

        public SimpleList(int capacity)
        {
            _size = capacity;
            _items = new T[capacity];
        }

        public void CopyTo(Array array, int index)
        {
            Array.Copy(_items, 0, array, index, _size);
        }

        public int Count
        {
            get { return _size; }
        }

        public bool IsSynchronized
        {
            get => false;
        }

        object ICollection.SyncRoot
        {
            get

            {
                if (_syncRoot == null)
                {
                    Interlocked.CompareExchange<object>(ref _syncRoot, new object(), null);
                }

                return _syncRoot;
            }
        }

        public T this[int index]
        {
            get { return _items[index]; }
            set { _items[index] = value; }
        }

        public void Add(T item)
        {
            if (_size == _items.Length)
            {
                Resize();
            }

            _items[_size++] = item;
        }

        public void Clear()
        {
            if (_size != 0)
            {
                _items = Array.Empty<T>();
                _size = 0;
            }
        }

        public bool Contains(T item)
        {
            if (item == null)
            {
                for (var i = 0; i < _size; i++)
                {
                    if (_items[i] == null)
                    {
                        return true;
                    }
                }
            }
            else
            {
                for (var i = 0; i < _size; i++)
                {
                    if (_items[i].Equals(item))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        

        public void ForEach(Action<T> action)
        {
            for (var i = 0; i < _size; i++)
            {
                action(_items[i]);
            }
        }

        public SimpleList<T> GetRange(int index, int count)
        {
            var newList = new SimpleList<T>(count);
            Array.Copy(_items, index, newList._items, 0, count);
            newList._size = count;
            return newList;
        }

        public bool Remove(T item)
        {
            int index = Array.IndexOf(_items, item, 0, _size);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            _size--;
            Array.Copy(_items, index + 1, _items, index, _size - index);
            _items[_size] = default(T);
        }

        public void RemoveRange(int index, int count)
        {
            _size -= count;
            if (index < _size)
            {
                Array.Copy(_items, index + count, _items, index, _size - index);
            }

            Array.Clear(_items, index, count);
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        [Serializable]
        public struct Enumerator : IEnumerator<T>
        {
            private SimpleList<T> list;
            private int index;
            private T current;

            internal Enumerator(SimpleList<T> list)
            {
                this.list = list;
                index = 0;
                current = default(T);
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                SimpleList<T> localList = list;

                if ((uint) index < (uint) localList._size)
                {
                    current = localList._items[index];
                    index++;
                    return true;
                }

                return false;
            }


            public T Current
            {
                get { return current; }
            }

            Object IEnumerator.Current
            {
                get { return current; }
            }

            void IEnumerator.Reset()
            {
                index = 0;
                current = default(T);
            }
        }
        
        private void Resize()
        {
            int newSize = _size > 0? _size * 2 : 1;
            var newItems = new T[newSize];
            Array.Copy(_items, 0, newItems, 0, _size);
            _items = newItems;
        }
    }
}
