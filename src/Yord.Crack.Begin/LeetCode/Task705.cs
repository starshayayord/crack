using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yord.Crack.Begin.LeetCode
{
    //0 <= element <= 1000000
    public class Task705
    {
        public class MyHashSet_BST
        {
            /** Initialize your data structure here. */
            private const double RehashRate = 0.75;
            private int Capacity = 100;
            private int Size = 0;
            private BSTNode[] Elements;

            public MyHashSet_BST()
            {
                Elements = new BSTNode[Capacity];
            }

            public void Add(int key)
            {
                int b = GetBucket(key);
                if (Elements[b] == null)
                {
                    Elements[b] = new BSTNode(key);
                    Size++;
                }
                else
                {
                    var r = Elements[b].Add(new BSTNode(key));
                    if (r)
                    {
                        Size++;
                    }
                }

                if (Size > Capacity * RehashRate)
                {
                    Rehash();
                }
            }

            public void Remove(int key)
            {
                int b = GetBucket(key);
                if (Elements[b] != null)
                {
                    var r = Elements[b].Remove(key);
                    if (r.Item2)
                    {
                        Elements[b] = r.Item1;
                        Size--;
                    }
                }
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                int b = GetBucket(key);
                if (Elements[b] != null)
                {
                    return Elements[b].Contains(key);
                }

                return false;
            }

            private int GetBucket(int key)
            {
                return key % Capacity;
            }

            private void Rehash()
            {
                Capacity *= 2;
                var newElements = new BSTNode[Capacity];
                foreach (var element in Elements)
                {
                    if (element != null)
                    {
                        foreach (var node in element.AllNodes())
                        {
                            if (node== null) continue;
                            var b = GetBucket(node.Data);
                            if (newElements[b] != null)
                            {
                                newElements[b].Add(new BSTNode(node.Data));
                            }
                            else
                            {
                                newElements[b] = new BSTNode(node.Data);
                            }
                        }
                    }
                }

                Elements = newElements;
            }

            private class BSTNode
            {
                public int Data;
                private BSTNode Right;
                private BSTNode Left;

                public BSTNode(int data)
                {
                    Data = data;
                }

                public bool Add(BSTNode node)
                {
                    if (Data == node.Data) return false;
                    if (node.Data > Data)
                    {
                        if (Right == null)
                        {
                            Right = node;
                        }
                        else
                        {
                            Right.Add(node);
                        }
                    }
                    else
                    {
                        if (Left == null)
                        {
                            Left = node;
                        }
                        else
                        {
                            Left.Add(node);
                        }
                    }

                    return true;
                }

                public bool Contains(int data)
                {
                    if (Data == data) return true;
                    if (data > Data)
                    {
                        if (Right == null)
                        {
                            return false;
                        }

                        return Right.Contains(data);
                    }

                    if (Left == null)
                    {
                        return false;
                    }

                    return Left.Contains(data);
                }

                public Tuple<BSTNode, bool> Remove(int data)
                {
                    bool r = false;
                    if (Data == data)
                    {
                        r = true;
                        if (Right == null && Left == null)
                        {
                            return new Tuple<BSTNode, bool>(null, true);
                        }

                        if (Right == null || Left == null)
                        {
                            return Right == null
                                ? new Tuple<BSTNode, bool>(Left, true)
                                : new Tuple<BSTNode, bool>(Right, true);
                        }

                        Data = Left.FindMax().Data;
                        Left.Remove(Data);
                    }

                    if (Data > data && Left != null)
                    {
                        var b = Left.Remove(data);
                        Left = b.Item1;
                        r = b.Item2;
                    }

                    if (Data < data && Right != null)
                    {
                        
                        var b = Right.Remove(data);
                        Right = b.Item1;
                        r = b.Item2;
                    }

                    return new Tuple<BSTNode, bool>(this, r);
                }

                public LinkedList<BSTNode> AllNodes()
                {
                    var q = new Queue<BSTNode>();
                    var l = new LinkedList<BSTNode>();
                    q.Enqueue(this);
                    while (q.Any())
                    {
                        var n = q.Dequeue();
                        l.AddFirst(n);
                        if (n.Left != null)
                        {
                            q.Enqueue(n.Left);
                        }

                        if (n.Right != null)
                        {
                            q.Enqueue(n.Right);
                        }
                    }

                    return l;
                }

                private BSTNode FindMax()
                {
                    BSTNode node = this;
                    while (node.Right != null)
                    {
                        node = node.Right;
                    }

                    return node;
                }
            }
        }

        public class MyHashSet_LL
        {
            private const double RehashCapacity = 0.75;
            private int Capacity = 10;
            private int Count;
            private LinkedList<int>[] Buckets;

            public MyHashSet_LL()
            {
                Buckets = new LinkedList<int>[Capacity];
            }

            public void Add(int key)
            {
                if (Contains(key)) return;
                if ((double) Count / Capacity > RehashCapacity)
                {
                    Capacity *= 2;
                    var newBuckets = new LinkedList<int>[Capacity];
                    foreach (var bucket in Buckets)
                    {
                        if (bucket == null) continue;
                        foreach (var l in bucket)
                        {
                            int newB = l % Capacity;
                            newBuckets[newB] ??= new LinkedList<int>();
                            newBuckets[newB].AddLast(l);
                        }
                    }

                    Buckets = newBuckets;
                }

                int b = key % Capacity;
                Buckets[b] ??= new LinkedList<int>();
                Buckets[b].AddLast(key);
                Count++;
            }

            public void Remove(int key)
            {
                if (!Contains(key)) return;
                int b = key % Capacity;
                Buckets[b].Remove(key);
                Count--;
            }

            public bool Contains(int key)
            {
                int b = key % Capacity;
                return Buckets[b] != null && Buckets[b].Contains(key);
            }
        }


        public class MyHashSet_Bit
        {
            private int[] elements;

            public MyHashSet_Bit()
            {
                elements = new int[1000000 / 32 + 1];
            }

            public void Add(int key)
            {
                int idx = key / 32;
                elements[idx] |= GetMask(key);
            }

            public void Remove(int key)
            {
                int idx = key / 32;
                elements[idx] &= ~GetMask(key);
            }

            public bool Contains(int key)
            {
                int idx = key / 32;
                return (GetMask(key) & elements[idx]) != 0;
            }

            private int GetMask(int key)
            {
                var bit = key % 32;
                return 1 << bit;
            }
        }
    }
}
