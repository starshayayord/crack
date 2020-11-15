using System.Collections;

namespace Yord.Crack.Begin.Chapter2
{
    // удалить узил из сеердины односвязного списка, т.е. узел не является начальным или конечным
    // ввод: узел С из списка A-B-C-D-E-F
    // вывод: ничего не возвращается, но новый список имеет вид  A-B-D-E-F
    public class Task3
    {
        public class Node : IEnumerable
        {
            public Node _next { get; private set; }
            public int _value { get; private set; }

            public Node(int v)
            {
                _value = v;
            }

            //PERFECT
            public static void RemoveMiddleElement(Node node)
            {
                //взяли ноду, которая следуюет за удаляемой
                var next = node._next;
                //присвоили "удаляемой" ноде значение следующей
                node._value = next._value;
                // удалили ноду, значение которой присвоили "удаляемой", связав удаляемую с следующе-следующей
                node._next = next._next;
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
