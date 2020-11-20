using System;

namespace Yord.Crack.Begin.Chapter3
{
    // LIFO, стопка тарелок
    // вставка и удаление элемента в постоянным временем
    public class SimpleStack<T>
    {
        private StackNode _top;
        
        private class StackNode
        {
            public T _value;

            public StackNode _next;

            public StackNode(T value)
            {
                _value = value;
            }
        }
        
        //извлечь элемент с вершины
        public T Pop()
        {
            if (_top == null)  throw  new IndexOutOfRangeException();
            var v = _top._value;
            _top = _top._next;
            return v;
        }
        
        //добавить элемент на вершину
        public void Push(T v)
        {
            var e = new StackNode(v);
            e._next = _top;
            _top = e;
        }

        //вернуть вершину
        public T Peek()
        {
            if (_top == null)  throw  new IndexOutOfRangeException();
            return _top._value;
        }

        //true, если stack пуст
        public bool IsEmpty()
        {
            return _top == null;
        }
    }
}
