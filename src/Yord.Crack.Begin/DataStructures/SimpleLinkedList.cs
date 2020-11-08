namespace Yord.Crack.Begin.DataStructures
{
    public class SimpleLinkedList<T>
    {
        private class Node
        {
            internal T data;

            internal Node next;

            internal Node(T value)
            {
                data = value;
            }
        }


        private Node head;

        private int count;

        public int Count
        {
            get => count;
        }

        public void AddFront(T value)
        {
            var newNode = new Node(value);
            newNode.next = head;
            head = newNode;
            count++;
        }
        
        public void AddLast(T value)
        {
            var newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var t = head;
                while (t.next != null)
                {
                    t = t.next;
                }

                t.next = newNode;
            }
            count++;
        }

        public bool AddAfterKey(T key, T value)
        {
            var newNode = new Node(value);
            
            if (head == null)
            {
                return false;
            }

            var t = head;
            while (t != null)
            {
                if (t.data.Equals(key))
                {
                    break;
                }
                t = t.next;
            }

            if (t == null)
            {
                return false;
            }
            newNode.next = t.next;
            t.next = newNode;
            count++;
            return true;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            while (current != null)
            {
                var t = current.next;
                current.next = prev;
                prev = current;
                current = t;
            }

            head = prev;
        }

        public bool Remove(T key)
        {
            if (head == null)
            {
                return false;
            }

            Node previous = null;
            var t = head;
            while (t != null)
            {
                if (t.data.Equals(key))
                {
                    break;
                }
                previous = t;
                t = t.next;
            }

            if (t == null)
            {
                return false;
            }

            //не голова
            if (previous != null)
            {
                previous.next = t.next;
            }
            //голова
            else
            {
                head = t.next;
            }
            count--;
            return true;
        }
    }
}
