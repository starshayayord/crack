using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // BST, с методами Insert, Remove(), Search(), GetRandomNode(вероятность выбора каждой ноды равна) 
    // PERFECT
    public class Task11
    {
        public class BSTree
        {
            private static Random _random = new Random();
            public BSTNode Root { get; set; }
            public int Size => Root?.Size ?? 0;

            public BSTNode GetRandomNode()
            {
                if (Root == null) return null;
                var index = _random.Next(0, Size);
                return Root.GetNth(index);
            }

            public void Insert(int value)
            {
                if (Root == null) Root = new BSTNode(value);
                else
                {
                    Root.Insert(value);
                }
            }

            public BSTNode Find(int value)
            {
                return Root?.Find(value);
            }


            public void Remove(int value, BSTNode n)
            {
                
                var current = n;
                var prevList = new List<BSTNode>();
                while (current != null && current.Value != value)
                {
                    prevList.Add(current);
                    current = current.Value > value ? current.Left : current.Right;
                }

                if (current == null) return;
                if (current.Left == null && current.Right == null)
                {
                    if (current == Root)
                    {
                        Root =null;
                        return;
                    }
                    if (prevList.Last().Left == current)
                    {
                        prevList.Last().Left = null;
                    }
                    else
                    {
                        prevList.Last().Right = null;
                    }
                }
                else
                {
                    if (current.Left == null || current.Right == null)
                    {
                        var notNullChild = current.Left ?? current.Right;
                        if (current == Root)
                        {
                            Root = notNullChild;
                            return;
                        }
                        if (prevList.Last().Left == current)
                        {
                            prevList.Last().Left = notNullChild;
                        }
                        else
                        {
                            prevList.Last().Right = notNullChild;
                        }
                    }
                    else
                    {
                        var minRight = current.Right.GetMin();
                        Remove(minRight.Value, current);
                        current.Value = minRight.Value;
                    }
                }
                foreach (var p in prevList)
                {
                    p.Size--;
                }
            }
            public void Remove(int value)
            {
                Remove(value, Root);
            }
        }

        public class BSTNode
        {
            public int Value { get; set; }
            public BSTNode Left { get; set; }
            public BSTNode Right { get; set; }
            public int Size { get; set; }

            public BSTNode(int value)
            {
                Value = value;
                Size = 1;
            }

            public BSTNode GetMin()
            {
                return Left != null ? Left.GetMin() : this;
            }

            public BSTNode Find(int value)
            {
                if (Value == value) return this;
                return Value > value ? Left?.Find(value) : Right?.Find(value);
            }

            public void Insert(int value)
            {
                if (Value > value)
                {
                    if (Left == null) Left = new BSTNode(value);
                    else Left.Insert(value);
                }
                else
                {
                    if (Right == null) Right = new BSTNode(value);
                    else Right.Insert(value);
                }

                Size++;
            }


            public BSTNode GetNth(int index)
            {
                var leftSize = Left?.Size ?? 0;
                if (index < leftSize)
                {
                    return Left.GetNth(index);
                }

                return index == leftSize ? this : Right.GetNth(index - (leftSize + 1));
            }
        }
    }
}
