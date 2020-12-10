using System;
using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter4
{
    // BST, с методами Insert, Remove(), Search(), GetRandomNode(вероятность выбора каждой ноды равна) 
    public class Task11
    {
        public class BSTree
        {
            private List<BSNode> NodeList = new List<BSNode>();
            private static Random _random = new Random();
            public int Count { get; private set; }

            public void Insert(int value)
            {
                NodeList.Add(new BSNode(value, Count));
                Root = Insert(Root, value);
                Count++;
            }

            private BSNode Insert(BSNode node, int value)
            {
                if (node == null) return NodeList[Count];
                if (node.Value > value) node.Left = Insert(node.Left, value);
                else node.Right = Insert(node.Right, value);
                return node;
            }

            public void Remove(int value)
            {
                Root = Remove(Root, value);
            }

            private BSNode Remove(BSNode n, int value, bool inner = false)
            {
                if (n == null) return n; //пустое дерево
                if (n.Value > value) n.Left = Remove(n.Left, value);
                else if (n.Value < value) n.Right = Remove(n.Right, value);
                else // нашли ноду, которую удаляем
                {
                    if (!inner)
                    {
                        Count--;
                        NodeList.RemoveAt(n.Index);
                    }

                    //есть только правое поддерево или ни одного
                    if (n.Left == null) return n.Right;
                    if (n.Right == null) return n.Left;
                    //есть оба поддерева
                    //для текущей ноды ищем меньшее из правых значений
                    n.Value = MinOfTwoChildren(n.Right);
                    //удаляем найденное
                    n.Right = Remove(n.Right, n.Value, true);
                }

                return n;
            }

            private static int MinOfTwoChildren(BSNode n)
            {
                var c = n;
                var min = c.Value;
                while (c.Left != null)
                {
                    min = c.Left.Value;
                    c = c.Left;
                }

                return min;
            }


            public BSNode Search(int value)
            {
                var n = Root;
                while (n != null)
                {
                    if (n.Value == value)
                    {
                        return n;
                    }

                    n = n.Value > value ? n.Left : n.Right;
                }

                return null;
            }

            public BSNode GetRandomNode()
            {
                if (Count == 0) return null;
                var index = _random.Next(0, Count);
                return NodeList[index];
            }


            public BSNode Root { get; set; }

            public class BSNode
            {
                public BSNode(int value, int index)
                {
                    Value = value;
                    Index = index;
                }

                public int Index { get; set; }

                public int Value { get; set; }

                public BSNode Left { get; set; }

                public BSNode Right { get; set; }
            }
        }
    }
}
