using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin
{
    public class DLinkedList<T> : IEnumerable<T>
    {
        private class DNode
        {
            public T Data;

            public DNode Next;

            public DNode Previous;

            public DNode(T data)
            {
                Data = data;
            }
        }

        private DNode _head;

        private int _count;

        public int Count
        {
            get => _count;
        }

        public void AddFront(T value)
        {

            var newNode = new DNode(value);
            if (_head != null)
            {
                newNode.Next = _head;
                _head.Previous = newNode;
            }
            _head = newNode;
            _count++;
        }

        public void AddLast(T value)
        {
            var newNode = new DNode(value);
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                var previous = _head;
                var t = _head.Next;
                while (t != null)
                {
                    previous = t;
                    t = t.Next;
                }

                previous.Next = newNode;
                newNode.Previous = previous;
            }

            _count++;
        }

        //простой случай, когда T не nullable, все уникальны
        public bool AddAfterKey(T key, T value)
        {
            
            var t = _head;
            while (t != null)
            {
                if (t.Data.Equals(key))
                {
                    var newNode = new DNode(value);
                    newNode.Previous = t;
                    newNode.Next = t.Next;
                    t.Next.Previous = newNode;
                    t.Next = newNode;
                    _count++;
                    return true;
                }

                t = t.Next;
            }

            return false;
        }
        //простой случай, когда T не nullable, все уникальны
        public bool Remove(T key)
        {
            var t = _head;
            while (t != null)
            {
                if (t.Data.Equals(key))
                {
                    t.Previous.Next = t.Next;
                    t.Next.Previous = t.Previous;
                    _count--;
                    return true;
                }
                t = t.Next;
            }
            return false;
        }

        public void Reverse()
        {
            DNode previous = null;
            var current = _head;
            while (current != null)
            {
                var tmp = current.Next;
                current.Next = previous;
                current.Previous = tmp;
                previous = current;
                current = tmp;
            }
            
            _head = previous;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return new Enumerator(this);
        }

        public class Enumerator : IEnumerator<T>
        {
            private DLinkedList<T> _list;
            private DNode _current;
            public Enumerator(DLinkedList<T> dLinkedList)
            {
                _list = dLinkedList;
            }

            public bool MoveNext()
            {
                _current = _current == null ? _list._head : _current.Next;
                return _current != null;
            }

            public void Reset()
            {
                _current = _list._head;
            }

            public T Current => _current.Data;

            object IEnumerator.Current => Current;

            public void Dispose()
            {
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
