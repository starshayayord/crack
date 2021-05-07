using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // вернуть preorder
    public class Task589
    {
        public class Node {
            public int val;
            public IList<Node> children;

            public Node() {}

            public Node(int _val) {
                val = _val;
            }

            public Node(int _val,IList<Node> _children) {
                val = _val;
                children = _children;
            }
        }
        

        public class Solution {
            public IList<int> Preorder(Node root)
            {
                var r = new List<int>();
                if (root == null)
                {
                    return r;
                }

                var s = new Stack<Node>();
                s.Push(root);
                while (s.Any())
                {
                    var n = s.Pop();
                    r.Add(n.val);
                    for (var i = n.children.Count - 1; i >= 0; i--)
                    {
                        s.Push(n.children[i]);
                    }
                }

                return r;
            }
            
        }
    }
}
