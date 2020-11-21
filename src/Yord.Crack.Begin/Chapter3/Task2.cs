using System;

namespace Yord.Crack.Begin.Chapter3
{
    // реализовать стек в котором Push, Pop и Min выполняются за O(1)
    public class Task2
    {
        //PERFECT
        //чуть лучше по памяти, потому что хранит стек (связный список) минимальных элементов
        // при добавлении, если элемент меньше ИЛИ РАВЕН минимальному, то он становится сверху стека-списка минимальных
        // при удалении, если удаляемое значение равно минимуму, то удаляем верхний элемент из стека минимальных
        // текущий минимальный равен верху стека-списка минимальных
        public class StackWithMin<T> where T : IComparable
        {
            private StackNode _top;
            private StackNode _min;

            private class StackNode
            {
                public StackNode(T value, StackNode next = null)
                {
                    _value = value;
                    _next = next;
                }

                public StackNode _next;

                public T _value;
            }

            public void Push(T value)
            {
                if (_top == null)
                {
                    _top = new StackNode(value);
                    _min = new StackNode(value);
                }
                else
                {
                    
                    if (Min().CompareTo(value) >= 0)
                    {
                        var newMin = new StackNode(value);
                        newMin._next = _min;
                        _min = newMin;
                    }

                    var newNode = new StackNode(value, _top);
                    _top = newNode;
                }
            }

            public T Pop()
            {
                var value = _top._value;
                _top = _top._next;
                if (value.Equals(_min._value))
                {
                    _min = _min._next;
                }
                return value;
            }

            public T Min()
            {
                return _min._value;
            }
        }
        
        //Решение требует значительных затрат памяти, т.к. каждый узел хранит минимум его подстека
        public class StackWithMin2<T> where T : IComparable
        {
            private StackNode _top;

            private class StackNode
            {
                public StackNode(T value, T subStackMin, StackNode next = null)
                {
                    _value = value;
                    _subStackMin = subStackMin;
                    _next = next;
                }

                public StackNode _next;

                public T _subStackMin;

                public T _value;
            }

            public void Push(T value)
            {
                if (_top == null)
                {
                    _top = new StackNode(value, value);
                }
                else
                {
                    var min = _top._subStackMin;
                    if (min.CompareTo(value) > 0)
                    {
                        min = value;
                    }

                    var newNode = new StackNode(value, min, _top);
                    _top = newNode;
                }
            }

            public T Pop()
            {
                var value = _top._value;
                _top = _top._next;
                return value;
            }

            public T Min()
            {
                return _top._subStackMin;
            }
        }
    }
}
