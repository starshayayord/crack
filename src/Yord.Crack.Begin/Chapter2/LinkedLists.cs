namespace Yord.Crack.Begin.Chapter2
{
    public class LinkedLists
    {
        public class SingleNode
        {
            private SingleNode _next;
            private int _value;

            public SingleNode(int value)
            {
                _value = value;
            }

            public void AppendToTail(int value)
            {
                var newEndNode = new SingleNode(value);
                var n = this;
                while (n._next != null)
                {
                    n = n._next;
                }

                n._next = newEndNode;
            }

            public SingleNode DeleteNode(SingleNode head, int value)
            {
                var n = head;
                if (n._value == value)
                {
                    return head._next;
                }

                while (n._next != null)
                {
                    if (n._next._value == value)
                    {
                        n._next = n._next._next;
                        return head;
                    }
                }

                return head;
            }
            //TODO
            // дан список из четного числа элементов вида a1->a2->a3->b1->b2->b3
            // необходимо преобразовать его к виду a1->b1->a2->b2->a3->b3
            public static SingleNode Reorganize(SingleNode head)
            {
                var p1 = head;
                var p2 = head;
                while (p1 != null)
                {
                    p2 = p2._next;
                    p1 = p1._next._next;
                }
                //p1 бежит в 2 раза быстрее, так что когда он достигнет конца, то p2 будет равен b1
                p1 = head;
                while (p2 != null)
                {
                    var t = p1._next;
                    p1._next = p2;
                    p2 = p2._next;
                    p1._next._next = p2 != null ? t : null;
                    p1 = p1._next._next;

                }
                return head;
            }
        }
    }
}
