using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter7
{
    // Хэш-таблица со связными списками для обработки коллизий
    public class Task12
    {
        public class MyHash<K, V>
        {

            private int _size;
            private List<LinkedListNode<K, V>> items;

            public int Size => _size;
            public MyHash(int capacity)
            {
                items = new List<LinkedListNode<K, V>>(capacity);
                for (var i = 0; i < capacity; i++)
                {
                    items.Add(null);
                }
            }

            public void AddOrUpdate(K key, V value)
            {
                var node = GetNodeForKey(key);
                if (node != null)
                {
                    // Ключ присутствует, обновить значение
                    node.Value = value;
                }
                else
                {
                    node = new LinkedListNode<K, V>(key,value);
                    var index = GetIndexForKey(key);
                    if (items[index] != null) // если на этом индексе уже есть ненулевая нода
                    {
                        // вставляем перед ней новую
                        node.Next = items[index];
                        node.Next.Prev = node;
                        
                    }

                    // теперь на текущем индексе первая - новая
                    items[index] = node;
                    _size++;
                }
            }

            public bool Remove(K key)
            {
                var node = GetNodeForKey(key);
                if (node == null)
                {
                    return false;
                }
                if (node.Prev != null)
                {
                    // если есть предыдущая, то просто убрали из цепочки
                    node.Prev.Next = node.Next;
                }
                else
                {
                    //обновление первого узла
                    var index = GetIndexForKey(key);
                    items[index] = node.Next;
                }

                // у следующей сменили предыдущую
                if (node.Next != null)
                {
                    node.Next.Prev = node.Prev;
                }

                _size--;
                return true;
            }

            public V GetValueOrDefault(K key)
            {
                var node = GetNodeForKey(key);
                return node != null ? node.Value : default;
            }

            private LinkedListNode<K, V> GetNodeForKey(K key)
            {
                var index = GetIndexForKey(key);
                var node = items[index];
                while (node != null)
                {
                    if (node.Key.Equals(key))
                    {
                        return node;
                    }

                    node = node.Next;
                }

                return null;
            }

            private int GetIndexForKey(K key)
            {
                return Math.Abs(key.GetHashCode() % items.Capacity);
            }
            
            private class LinkedListNode<K, V>
            {
                public LinkedListNode<K, V> Next;
                public LinkedListNode<K, V> Prev;
                public K Key;
                public V Value;

                public LinkedListNode(K k, V v)
                {
                    Key = k;
                    Value = v;
                }
            }
        }
    }
}
