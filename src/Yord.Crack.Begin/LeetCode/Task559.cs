using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть макс длину дерева
    public class Task559
    {
        public static int MaxDepth2(Node root)
        {
            var maxDepth = 0;
            if (root == null) return maxDepth;
            var q = new Queue<Node>();
            q.Enqueue(root);
            //сначала в очереди только начальная нода
            //каждый раз вынимаем из очереди текущий уровень (+1 к глубине)
            //и кладем всех детей у нод текущего уровня в очередь
            //повторить, пока в очереди есть хоть 1 уровень
            while (q.Any())
            {
                var currentLevel = q.Count;
                for (var i = 0; i < currentLevel; i++)
                {
                    var node = q.Dequeue();
                    foreach (var nodeChild in node.children)
                    {
                        q.Enqueue(nodeChild);
                    }
                    
                }

                maxDepth++;
            }

            return maxDepth;
        }
        public static int MaxDepth(Node root)
        {
            return CheckDepth(0, root);
        }

        private static int CheckDepth(int currentDepth, Node root)
        {
            if (root == null) return currentDepth;
            currentDepth++;
            if (root.children?.Any() == true)
            {
                currentDepth = root.children.Max(c => CheckDepth(currentDepth, c));
            }

            return currentDepth;
        }
        public class Node {
            public int val;
            public IList<Node> children;

            public Node() {}

            public Node(int _val) {
                val = _val;
            }

            public Node(int _val, IList<Node> _children) {
                val = _val;
                children = _children;
            }
        }
    }
}
