using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter2
{
    //напишите код для удаления дублиатов в связном списке
    public class Task1
    {
        public class Node : IEnumerable
        {
            private Node _next;
            private int _value;

            public Node(int v)
            {
                _value = v;
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
            
            //PERFECT, сложнее для понимания
            public static Node RemoveUnsortedDuplicates3(Node head)
            {
                if (head == null)
                {
                    return null;
                }

                var current = head;
                Node previous = null;

                while (current != null)
                {
                    var runner = head;
                    while (runner != current)
                    {
                        if (runner._value == current._value)
                        {
                            previous._next = current._next;
                            current = current._next;
                            // не может быть более одного дубликата перед элементом, т.к. они уже будут удалены
                            break;
                        }

                        runner = runner._next;
                    }
                    // если runner == current, то в цикле дубликатов не найдено, тогда увеличивает текущий
                    // иначе мы зашли в break (нашли дубликат) и текущий уже был перемещен на следующий
                    if (runner == current)
                    {
                        previous = current;
                        current = current._next;
                    }
                }

                return head;
            }

            // PERFECT
            public static Node RemoveUnsortedDuplicates2(Node head)
            {
                if (head == null)
                {
                    return null;
                }

                var current = head;
                // берем текущий элемент убираем все элементы, которые равные ему в оставшейся части списка
                // дошли до конца? сдвигаем текущий
                while (current != null)
                {
                    var runner = current;
                    while (runner._next != null)
                    {
                        if (runner._next._value != current._value)
                        {
                            runner = runner._next;
                        }
                        else
                        {
                            runner._next = runner._next._next;
                        }
                    }

                    current = current._next;
                }

                return head;
            }

            // используется дополнительная память на хэшсет
            public static Node RemoveUnsortedDuplicates(Node head)
            {
                var n = head;
                var table = new HashSet<int>();
                Node p = null;
                while (n != null)
                {
                    if (table.Contains(n._value))
                    {
                        p._next = n._next;
                    }
                    else
                    {
                        table.Add(n._value);
                        p = n;
                    }

                    n = n._next;
                }

                return head;
            }

            public static Node RemoveSortedDuplicates(Node head)
            {
                var n = head;
                while (n._next != null)
                {
                    if (n._value == n._next._value)
                    {
                        n._next = n._next._next;
                    }
                    else
                    {
                        n = n._next;
                    }
                }

                return head;
            }
        }
    }
}
