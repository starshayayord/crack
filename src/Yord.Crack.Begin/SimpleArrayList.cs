using System;
using System.Collections;

namespace Yord.Crack.Begin
{
    public class SimpleArrayList : IEnumerable
    {
        private object[] _items;
        private int _size;
        private const int _defaultCapacity = 4;

        public SimpleArrayList(int? capacity = null)
        {
            _items = new object[capacity ?? _defaultCapacity];
        }

        public int Count
        {
            get => _size;
        }

        public void Add(object item)
        {
            if (_size == _items.Length)
            {
                Resize();
            }

            _items[_size] = item;
            _size++;
        }

        public void InsertAt(int index, object item)
        {
            if (index >= _size)
            {
                throw new ArgumentOutOfRangeException(nameof(index));
            }

            if (_size == _items.Length)
            {
                Resize();
            }

            
            Array.Copy(_items, index, _items, index + 1, _size - index);

            _items[index] = item;
            _size++;
        }

        public bool Remove(object item)
        {
            for (var i = 0; i < _items.Length; i++)
            {
                if (_items[i].Equals(item))
                {
                    _size--;
                    if (i != _size)
                    {
                        Array.Copy(_items, i + 1, _items, i, _items.Length);
                    }

                    _items[_size] = null;
                    return true;
                }
            }

            return false;
        }

        private void Resize()
        {
            var newSize = _size == 0 ? _defaultCapacity : _size * 2;
            var newItems = new object[newSize];
            Array.Copy(_items, 0, newItems, 0, _items.Length);
            _items = newItems;
        }

        public IEnumerator GetEnumerator()
        {
            return new Enumerator(this);
        }

        private class Enumerator : IEnumerator
        {
            private SimpleArrayList _arrayList;
            private int _current;

            public Enumerator(SimpleArrayList arrayList)
            {
                _arrayList = arrayList;
                _current = -1;
            }

            public bool MoveNext()
            {
                if (_current >= _arrayList._size - 1)
                {
                    return false;
                }

                _current++;
                return true;
            }

            public void Reset()
            {
                _current = -1;
            }

            public object Current => _arrayList._items[_current];
        }
    }
}
