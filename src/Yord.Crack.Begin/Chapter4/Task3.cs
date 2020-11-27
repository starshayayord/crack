using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // для бинарного дерева сделать метод, который создает связный список для всех узлов на каждой глубине, т.е.
    // для дерева глубины D должно получиться D связных списков
    public class Task3
    {
        public static List<LevelLinkedList> ConvertToLists2(BinaryTree tree)
        {
            // DFS, считаем кол-во узлов на каждом уровне
            var lvl = GetLvlCount(new Dictionary<int, int>(), 0, tree.Root);
            var currentLvl = 1;
            var list = new List<LevelLinkedList>();
            var l = new LevelLinkedList();
            //BFS добавляем узлы в новый связный список, уменьшая кол-во узлов на уровне
            //если узел последний на уровне, то список уровня полон и кладется в список результатов
            var queue = new Queue<BinaryTreeNode>();
            queue.Enqueue(tree.Root);
            while (queue.Any())
            {
                var n = queue.Dequeue();
                if (n == null) continue;
                l.Add(n.Value);
                if (--lvl[currentLvl] == 0)
                {
                    currentLvl++;
                    list.Add(l);
                    l = new LevelLinkedList();
                }
                if (n.Left != null) queue.Enqueue(n.Left);
                if (n.Right != null) queue.Enqueue(n.Right);
            }

            return list;
        }

        private static Dictionary<int, int> GetLvlCount(Dictionary<int, int> lvl, int i, BinaryTreeNode n)
        {
            if (n != null)
            {
                GetLvlCount(lvl, ++i, n.Left);
                if (lvl.ContainsKey(i)) lvl[i]++;
                else lvl[i] = 1;
                GetLvlCount(lvl, i, n.Right);
            }

            return lvl;
        }

        public class BinaryTree
        {
            public BinaryTreeNode Root { get; set; }
        }

        public class BinaryTreeNode
        {
            public int Value { get; set; }

            public BinaryTreeNode Left { get; set; }

            public BinaryTreeNode Right { get; set; }
        }

        public class LevelLinkedList
        {
            public LinkedListNode Root { get; set; }

            public void Add(int v)
            {
                if (Root == null)
                {
                    Root = new LinkedListNode(v);
                }
                else
                {
                    var n = new LinkedListNode(v, Root);
                    Root = n;
                }
            }
        }

        public class LinkedListNode
        {
            public int Value { get; set; }

            public LinkedListNode Next { get; set; }

            public LinkedListNode(int v, LinkedListNode n = null)
            {
                Value = v;
                Next = n;
            }
        }
    }
}
