using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task590
    {
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
        
        public static IList<int> Postorder(Node root)
        {
            List<int> r = new List<int>();
            Postorder(root, r);
            return r;
        }

        private static void Postorder(Node node, IList<int> r)
        {
            if (node == null) return;
            for (int i=0; i< node.children.Count; i++)
            {
                Postorder(node.children[i], r);
            }
            r.Add(node.val);
        }
        
        public static IList<int> Postorder_Iter(Node root)
        {
            List<int> r = new List<int>();
            Stack<Node> s = new Stack<Node>();
            s.Push(root);
            while (s.Any())
            {
                Node n = s.Pop();
                if (n==null) continue;
                r.Add(n.val);
                for (int i=0; i< n.children.Count; i++)
                {
                    s.Push(n.children[i]);
                }
            }

            r.Reverse();
            return r;
        }
    }
}
