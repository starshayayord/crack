using System;

namespace Yord.Crack.Begin.Chapter3
{
    //FIFO, традиционная очередь
    public class SimpleQueue<T>
    {
        private class QueueNode
        {
            public T _value;

            public QueueNode _next;

            public QueueNode(T v)
            {
                _value = v;
            }
        }

        private QueueNode _first;
        private QueueNode _last;

        public void Enqueue(T v)
        {
            var n = new QueueNode(v);
            if (_last != null)
            {
                _last._next = n;
            }

            _last = n;
            if (_first == null)
            {
                _first = n;
            }
        }

        public T Dequeue()
        {
            if (_first == null) throw new IndexOutOfRangeException();
            var v = _first._value;
            _first = _first._next;
            if (_first == null)
            {
                _last = null;
            }

            return v;
        }

        public T Peek()
        {
            if (_first == null) throw new IndexOutOfRangeException();
            return _first._value;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }
    }
}
