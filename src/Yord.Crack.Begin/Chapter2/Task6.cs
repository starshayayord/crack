using System;
using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter2
{
    // проверить, является ли связный список палиндромом
    public class Task6
    {
        public class Node : IEnumerable
        {
            public Node _next { get; private set; }
            public int _value { get; private set; }

            // PERFECT
            public static bool IsPalindrome(Node node)
            {
                var stack = new Stack<int>();
                Node slow = node;
                Node fast = node;
                // случай четного и нечетного кол-ва элементов в списке
                while (fast?._next != null)
                {
                    stack.Push(slow._value);
                    //один мотаем до конца (в два раза быстрее) => второй мотаем до середины
                    slow = slow._next;
                    fast = fast._next._next;
                }

                if (fast != null) //значит сработало условие fast._next != null и это нечетный список
                {
                    slow = slow._next; //пропуск нечетной середины, сама себе палиндром
                }

                while (slow != null)
                {
                    if (stack.Pop() != slow._value)
                    {
                        return false;
                    }

                    slow = slow._next;
                }

                return true;
            }

            public static bool IsPalindromeRec2(Node node)
            {
                return node?._next == null || IsPalindromeRec2Ref(ref node, node._next);
            }

            private static bool IsPalindromeRec2Ref(ref Node head, Node back)
            {
                var isPalindrome = true;
                // крутим до конца списка, при этом имея реф на голову изначального списка
                if (back._next != null)
                {
                    isPalindrome = IsPalindromeRec2Ref(ref head, back._next);
                }

                //каждый раз сравниваем значение текущей головы и текущего элемента из второй половины
                isPalindrome &= head._value == back._value;
                //смещаем голову вперед по списку
                //back отматвается назад сам за счет разматывания стека рекурсии
                head = head._next;
                return isPalindrome;
            }

            public static bool IsPalindromeStackQueue(Node node)
            {
                var queue = new Queue<int>();
                var stack = new Stack<int>();
                //запихиваем весь список в стек и в очередь
                while (node != null)
                {
                    queue.Enqueue(node._value);
                    stack.Push(node._value);
                    node = node._next;
                }

                //вытаскиваем по элементу из стэка (с конца списка) и из очереди (с начала списка)
                while (queue.Count > 0 && stack.Count > 0)
                {
                    if (queue.Dequeue() != stack.Pop())
                    {
                        return false;
                    }
                }

                return true;
            }


            public static bool IsPalindromeRec(Node node)
            {
                var length = GetLength(node);
                var r = IsPalindromeRec(node, length);
                return r.Item2;
            }

            // пока не дошли до середины, вызываем эту функцию, просто двигая список дальше
            // в начале очередного вызова функции проверяем середину и начинаем раскручивать обратно head
            // но сранивать с нодой, которая находится дпльше серединына том же расстоянии
            public static Tuple<Node, bool> IsPalindromeRec(Node head, int length)
            {
                if (head == null || length == 0) // случай пустого списка
                {
                    return new Tuple<Node, bool>(null, true);
                }

                //проверка середин
                if (length == 1) // случай нечетного списка
                {
                    return new Tuple<Node, bool>(head._next, true); // середина, сама себе палиндром
                }

                if (length == 2) // случай четного списка
                {
                    // проверяем 2 ноды в середине. Если они - палиндром, то true /иначе - false
                    return new Tuple<Node, bool>(head._next._next, head._value == head._next._value);
                }
                //закончили проверку середин

                // проверяем, является ли палиндромом списко без двух крайних нод.
                // ноду на самом деле смещаем на Next
                //то есть в реальности смещаемся на 1, но длину-бегунок уменьшаем на 2,
                //что придти к середине, когда она будет 1 или 2 (быстрее в 2 раза)
                var r = IsPalindromeRec(head._next, length - 2);
                if (!r.Item2 || r.Item1 == null) // если уже получили false или дошли до конца, то выдача результата
                {
                    return r;
                }

                // сравниваем текущую голову с текущим элементом на равном расстоянии от середины и смещаем ноду на next
                return new Tuple<Node, bool>(r.Item1._next, r.Item1._value == head._value);
            }

            private static int GetLength(Node n)
            {
                var l = 0;
                while (n != null)
                {
                    l++;
                    n = n._next;
                }

                return l;
            }

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
        }
    }
}
