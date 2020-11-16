using System;
using System.Collections;

namespace Yord.Crack.Begin.Chapter2
{
    // функция суммирует два числа-списка, где числа записаны в обратном порядке,
    // а затем возвращает связный спискок из результата (тоже в обратном порядке
    // (7->1->6) + (5 ->9->2) = 617 + 295 = 912 = 2 -> 1 -> 9
    public class Task5
    {
        public class Node : IEnumerable
        {
            public Node _next { get; private set; }
            public int _value { get; private set; }

            public Node(int v)
            {
                _value = v;
            }

            // реализуйте задачу предполагая, что цифры записаны в прямом порядке
            //(6->1->7)+(2->9->5)=617+295=912=(9->1->2)
            public static Node DirectSum(Node node1, Node node2)
            {
                if (node1 == null)
                {
                    return node2;
                }

                if (node2 == null)
                {
                    return node1;
                }

                var l1 = GetListLength(node1);
                var l2 = GetListLength(node2);
                // добавляем вперед столько 0, на сколько в длину различаются списки,
                // тем самым делаем их одинаковыми по длине
                if (l1 < l2)
                {
                    node1 = AddZeros(node1, l2 - l1);
                }

                if (l2 < l1)
                {
                    node2 = AddZeros(node2, l1 - l2);
                }

                var sumResult = PartialSum(node1, node2);
                //если на последней операции получили число больше 9, то есть остаток,
                // который вставим впереди текущей головы
                if (sumResult.Item2 == 0)
                {
                    return sumResult.Item1;
                }

                return insertBefore(sumResult.Item1, sumResult.Item2);
            }

            // возвращаем новую head результирующего списка и остаток
            private static Tuple<Node, int> PartialSum(Node n1, Node n2)
            {
                //списки одинаковой длины, одновременно станут null
                if (n1 == null || n2 == null)
                {
                    return new Tuple<Node, int>(null, 0);
                }

                var partialSum = PartialSum(n1._next, n2._next);
                // первый раз partialSum.Item2 == 0, а partialSum.Item1 == null
                // т.е. первый раз перед null-нодой вставим единицы и сохраним кол-во десятков
                // второй раз перед головой вставим единицы от суммы остатка и новых нод
                // и так далее, пока не останется последний остаток, (который мб равен 0), с которым выйдем из функции
                var val = partialSum.Item2 + n1._value + n2._value;
                var result = insertBefore(partialSum.Item1, val % 10);
                return new Tuple<Node, int>(result, val / 10);
            }

            private static Node insertBefore(Node n, int v)
            {
                var newNode = new Node(v);
                newNode._next = n;
                return newNode;
            }

            private static Node AddZeros(Node node, int c)
            {
                for (var i = 0; i < c; i++)
                {
                    var newNode = new Node(0);
                    newNode._next = node;
                    node = newNode;
                }

                return node;
            }

            private static int GetListLength(Node n)
            {
                var length = 0;
                while (n != null)
                {
                    length++;
                    n = n._next;
                }

                return length;
            }


            //PERFECT 
            // рекурсивный алгоритм из книги. вроде мой не хуже
            public static Node ReverseSum3(Node node1, Node node2, int mod = 0)
            {
                if (node1 == null && node2 == null && mod == 0)
                {
                    return null;
                }

                var value = mod + (node1?._value ?? 0) + (node2?._value ?? 0);
                var result = new Node(value % 10);
                if (node1 != null || node2 != null)
                {
                    var more = ReverseSum3(node1?._next, node2?._next, value >= 10 ? 1 : 0);
                    result._next = more;
                }

                return result;
            }

            // мой вариант, итеративный, сложнее читается
            public static Node ReverseSum2(Node node1, Node node2)
            {
                if (node1 == null && node2 == null)
                {
                    return null;
                }

                if (node1 == null)
                {
                    return node2;
                }

                if (node2 == null)
                {
                    return node1;
                }

                Node sumHead = null;
                var addOne = false;
                Node n = null;
                while (node1 != null || node2 != null || addOne)
                {
                    var nextValue = (node1?._value ?? 0) + (node2?._value ?? 0) + (addOne ? 1 : 0);
                    addOne = nextValue > 9;

                    if (sumHead == null)
                    {
                        sumHead = new Node(nextValue % 10);
                        n = sumHead;
                    }
                    else
                    {
                        n._next = new Node(nextValue % 10);
                        n = n._next;
                    }

                    node1 = node1?._next;
                    node2 = node2?._next;
                }

                return sumHead;
            }

            public static Node ReverseSum(Node node1, Node node2)
            {
                var sum = 0;
                var multiplier = 1;
                while (node1 != null)
                {
                    sum += node1._value * multiplier;
                    multiplier *= 10;
                    node1 = node1._next;
                }

                multiplier = 1;
                while (node2 != null)
                {
                    sum += node2._value * multiplier;
                    multiplier *= 10;
                    node2 = node2._next;
                }

                Node sumHead = null;
                Node n = null;
                while (sum > 0)
                {
                    var val = sum % 10;
                    if (sumHead == null)
                    {
                        sumHead = new Node(val);
                        n = sumHead;
                    }
                    else
                    {
                        n._next = new Node(val);
                        n = n._next;
                    }

                    sum /= 10;
                }

                return sumHead;
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
