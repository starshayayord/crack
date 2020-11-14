using System.Collections;

namespace Yord.Crack.Begin.Chapter2
{
    // найти K-тый элемент с конца в односвязном списке
    public class Task2
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
            
            //PERFECT
            //итерационный алгоритм
            public static int FindKFromEnd3(Node head, int k)
            {
                var p1 = head;
                var p2 = head;

                if (k <= 0) return -1;

                // перемещаем p2 на K нод вперед. p1 всё еще равен голове
                for (var i = 0; i < k - 1; i++)
                {
                    if (p2 == null)
                    {
                        return -1; // K > размер списка
                    }

                    p2 = p2._next;
                }
                if (p2 == null)
                { // размер списка == k-1
                    return -1;
                }

                // смещаем P2 до конца списка
                // в это же время смещаем P1
                //когда P2 достигнет конца, то P1 будет K'ым элементом
                //(то есть P2 на K'ой позиции, ему до конца осталось (size-k)
                //то есть p1 как раз не дойдет до конца K элементов
                while (p2._next != null)
                {
                    p1 = p1._next;
                    p2 = p2._next;
                }

                return p1._value;
            }

            // рекурсивный алгоритм 
            // PERFECT
            public static int FindKFromEnd2(Node head, int k)
            {
                if (k == 0 || head == null) //конец списка
                {
                    return -1;
                }

                var result = FindKFromEndRec(head, k);
                if (result.Node == null) return -1;
                return result.Node._value;
            }
            
            private static Result FindKFromEndRec(Node head, int k)
            {
                if (head == null) //конец списка*
                {
                    return new Result(null, 0);
                }

                var result = FindKFromEndRec(head._next, k);

                if (result.Node == null) //когда дошли до конца списка*
                {
                    result.Count++; // увеличиваем от конца .Counter на 1, .Node не меняется, пока не сравняемся с K

                    if (result.Count == k) //если он станет равен K
                    {
                        result.Node = head; // то возврщаем текущую ноду, иначе вернется null
                    }
                }

                return result;
            }

            internal class Result
            {
                public Node Node { get; set; }
                public int Count { get; set; }

                public Result(Node node, int count)
                {
                    Node = node;
                    Count = count;
                }
            }

            public int FindKFromEnd(int k)
            {
                var size = 0;
                var n = this;
                while (n != null)
                {
                    size++;
                    n = n._next;
                }

                if (k > size)
                {
                    return -1;
                }

                n = this;
                var counter = size;
                while (counter != k)
                {
                    counter--;
                    n = n._next;
                }

                return n._value;
            }
        }
    }
}
