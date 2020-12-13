using System.Collections;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter2
{
    // вернуть начальный юзел петли в кольцевом списке
    // A->B->C->D->E->C Вернуть С
    //
    public class Task8
    {
        public class Node : IEnumerable
        {
            public Node _next { get; set; }
            public int _value { get; set; }


            public Node(int v)
            {
                _value = v;
            }

            public static Node GetLoopNode2(Node head)
            {
                var slow = head;
                var fast = head;
                // если петли нет, то просто выйдем из вайла
                // если кольцо, то когда slow пройдет весь список, тогда fast пройдет списко 2 раза и они встретятся
                // если петля, то встретятся, когда fast пойдет на второй круг
                //они встретятся не позже, чем slow пойдет на второй круг
                while (fast?._next != null)
                {
                    slow = slow._next;
                    fast = fast._next._next;
                    if (fast == slow)
                    {
                        break;
                    }
                }

                if (fast?._next == null)
                {
                    return null; // список без петли, т.к. дошли до конца
                }

                // получается, что относительно головы оба прошли одно и то же относительное расстояние, т.к пересеклись
                // но, медленный, чтобы дойти сюда, сделал К шагов, а быстрый K*2
                // относительно начала медленный прошел K, а быстрый К и еще какое-то кол-во полных кругов
                // если бы это было кольцо, то медленный и быстрый сошлись бы в начале, т.к. быстрый прошел ровно х2
                // а если сначала до петли был хвост, то быстрый отстал от медленного ровно на этот хвост
                // значит когда они пересекутся, то slow пройдет ровно хвост
                slow = head;
                
                while (slow != fast)
                {
                    slow = slow._next;
                    fast = fast._next;
                }

                return fast;
            }

            //много памяти
            public static Node GetLoopNode(Node head)
            {
                var map = new HashSet<Node>();
                while (head != null)
                {
                    if (map.Contains(head))
                    {
                        return head;
                    }
                    map.Add(head);
                    head = head._next;
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
