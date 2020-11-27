using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // для бинарного дерева сделать метод, который создает связный список для всех узлов на каждой глубине, т.е.
    // для дерева глубины D должно получиться D связных списков
    public class Task3
    {
        //PERFECT (2)
        // BFS, значит идем по уровням
        //чтобы узнать узлы уровня N мы смотрим ДОЧЕРНИЕ узлы уровня N-1
        public static List<LinkedList<BinaryTreeNode>> ConvertToListsBfs(BinaryTree tree)
        {
            var list = new List<LinkedList<BinaryTreeNode>>();
            var currentLevelList = new LinkedList<BinaryTreeNode>();
            if (tree.Root != null) currentLevelList.AddFirst(tree.Root);

            while (currentLevelList.Any()) //пока есть узлы на текущем уровне
            {
                list.Add(currentLevelList); // добавили предыдущий 
                var parents = currentLevelList; // запомнили его как родительский
                currentLevelList = new LinkedList<BinaryTreeNode>(); // сделали чистый лист
                foreach (var parent in parents) //добавили в чистый лист всех детей всех родителей
                {
                    if (parent.Left != null) currentLevelList.AddFirst(parent.Left);
                    if (parent.Right != null) currentLevelList.AddFirst(parent.Right);
                }
            }

            return list;
        }

        //PERFECT (1) на самом деле при подсчете узлов на уровне (DFS) можно было сразу добавлять в списки
        public static List<LevelLinkedList> ConvertToListsDfs(BinaryTree tree)
        {
            if (tree.Root == null) return null;
            var list = new List<LevelLinkedList>();
            ConvertToLists(list, tree.Root, 0);
            return list;
        }

        private static void ConvertToLists(List<LevelLinkedList> list, BinaryTreeNode node, int level)
        {
            LevelLinkedList levelList;
            //уровни посещаются по порядку, т.е. при посещении N уровня в списке будет N-1 связных списков
            if (list.Count == level) // уровень еще не содержится в списке
            {
                //добавим пустой связный список в конец 
                levelList = new LevelLinkedList();
                list.Add(levelList);
            }
            else
            {
                //возьмем существующий список уровня 
                levelList = list[level];
            }

            levelList.Add(node.Value);
            if (node.Left != null) ConvertToLists(list, node.Left, level + 1);
            if (node.Right != null) ConvertToLists(list, node.Right, level + 1);
        }

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
