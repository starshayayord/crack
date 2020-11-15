using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter2
{
    // Разбить связный список вокруг Х так, чтобы все узлы меньшие Х предшествовали узлам больше или равным Х. 
    // Если Х содержится в списке, то значения Х должны следовать после элементов, меньших Х, т.е.
    // элемент(ы) разбивки может находиться где угодно в правой части
    // 3-5-8-5-10-2-1, разбиваем по [5]
    // 3-1-2-10-5-5-8
    public class Task4
    {
        public class Node : IEnumerable
        {
            public Node _next { get; private set; }
            public int _value { get; private set; }

            public Node(int v)
            {
                _value = v;
            }

            public static Node SplitList(Node head, int splitByValue)
            {
                var n = head;
                var next = head._next;
                //пока не дошли до конца
                while (next!= null)
                {
                    //если меньший элемент слева, то просто смещаем оба указателя дальше
                    if (n._value < splitByValue)
                    {
                        n = n._next;
                    }
                    else
                    {
                        //если N >= splitByValue, то меняем их местами в next, только если next < splitByValue
                        if (next._value < splitByValue)
                        {
                            var t = n._value;
                            n._value = next._value;
                            next._value = t;
                            n = n._next;
                        }

                        next = next._next;
                    }
                }
                return head;
            }

            public void Append(int v)
            {
                var n = this;
                while (n._next != null)
                {
                    n = n._next;
                }

                n._next = new Node(v);
            }

            public IEnumerator GetEnumerator()
            {
                return new Enumerator(this);
            }

            private struct Enumerator : IEnumerator
            {
                private Node _head;
                private Node _current;

                public Enumerator(Node head)
                {
                    _head = head;
                    _current = null;
                }

                public bool MoveNext()
                {
                    _current = _current == null ? _head : _current._next;
                    return _current != null;
                }

                public void Reset()
                {
                    _current = _head;
                }

                public object Current => _current._value;
            }
        }
    }
}
