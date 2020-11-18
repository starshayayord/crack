using System;
using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter2
{
    // найти пересечение односвязных списков, если оно имеется (т.е. узел, который совпадает по значению и по ссылке)
    public class Task7
    {
        public class Node : IEnumerable
        {
            public Node _next { get; set; }
            public int _value { get; set; }


            public Node(int v)
            {
                _value = v;
            }

            //PERFECT
            public static Node GetIntersection2(Node node1, Node node2)
            {
                var tail1L1 = GetLastNodeAndLength(node1);
                var tail2L2 = GetLastNodeAndLength(node2);
                // так как список односвязный, то у ноды-пересечения может быть только один уникальный _next
                // то есть все ноды у списков, следующие за нодой-пересечением - общие
                // Вывод: если хвосты списков не совпадают, значит они не пересакаются
                if (tail1L1.Item1 != tail2L2.Item1)
                {
                    return null;
                }

                // мотаем длинный список на разницу
                if (tail1L1.Item2 > tail2L2.Item2)
                {
                    node1 = SkipNodes(node1, tail1L1.Item2 - tail2L2.Item2);
                }

                if (tail1L1.Item2 < tail2L2.Item2)
                {
                    node2 = SkipNodes(node2, tail2L2.Item2 - tail1L1.Item2);
                }

                // мотаем списки, пока не найдем пересечение
                while (node1 != node2)
                {
                    node1 = node1._next;
                    node2 = node2._next;
                }

                return null;
            }

            private static Node SkipNodes(Node n, int skip)
            {
                for (var i = 0; i < skip; i++)
                {
                    n = n._next;
                }

                return n;
            }

            private static Tuple<Node, int> GetLastNodeAndLength(Node n)
            {
                var l = 0;
                var p = n;
                while (n != null)
                {
                    l++;
                    p = n;
                    n = n._next;
                }

                return new Tuple<Node, int>(p, l);
            }


            public static Node GetIntersection(Node node1, Node node2)
            {
                var map = new Dictionary<int, List<Node>>();
                while (node1 != null)
                {
                    if (map.TryGetValue(node1._value, out var list))
                    {
                        list.Add(node1);
                    }
                    else
                    {
                        map[node1._value] = new List<Node> {node1};
                    }

                    node1 = node1._next;
                }

                while (node2 != null)
                {
                    if (map.TryGetValue(node2._value, out var list))
                    {
                        foreach (var n in list)
                        {
                            if (n == node2)
                            {
                                return n;
                            }
                        }
                    }

                    node2 = node2._next;
                }

                return null;
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
