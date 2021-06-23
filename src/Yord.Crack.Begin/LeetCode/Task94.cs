using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    public class Task94
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public static IList<int> InorderTraversal2(TreeNode root)
        {
            var l = new List<int>();
            if (root == null)
            {
                return l;
            }

            var stack = new Stack<TreeNode>();
            var cur = root;
            while (cur!=null || stack.Any())
            {
                //засунули все левые
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.left;
                }
                //вытащили самую глубокую левую и добавили
                cur = stack.Pop();
                l.Add(cur.val);
                //берем правую самой глубокой левой
                //затем либо добавим в стек ее+ее левые,
                //либо (если она null)возьмем левую на уровень выше из стека (она же root текущей)
                cur = cur.right;
            }

            return l;
        }
        

        public static IList<int> InorderTraversal(TreeNode root)
        {
            var l = new List<int>();
            InorderTraversal(root, l);
            return l;
        }

        private static void InorderTraversal(TreeNode node, List<int> l)
        {
            if (node == null)
            {
                return;
            }

            InorderTraversal(node.left, l);
            l.Add(node.val);
            InorderTraversal(node.right, l);
        }
    }
}
