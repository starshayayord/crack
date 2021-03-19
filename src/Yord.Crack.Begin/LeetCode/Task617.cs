using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Смерджить деревья. Если ноды налагаются друг на друга, то сложить значения
    public class Task617
    {
        public static TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            root1.val += root2.val;

            root1.left = MergeTrees(root1.left, root2.left);
            root1.right = MergeTrees(root1.right, root2.right);

            return root1;
        }

        public static TreeNode MergeTrees_Iter(TreeNode root1, TreeNode root2)
        {
            if (root1 == null) return root2;
            if (root2 == null) return root1;
            Stack<TreeNode[]> stack = new Stack<TreeNode[]>();
            stack.Push(new[] {root1, root2});
            while (stack.Any())
            {
                var r = stack.Pop();
                if (r[0] == null || r[1] == null)
                {
                    //если r[0] == null, значит дошли до края root1, уже приклеив все, что могли от root2 
                    //если r[1] == null, значит root1 не с чем склеивать, оставляем как есть.
                    continue;
                }

                r[0].val += r[1].val;
                if (r[0].left == null)
                {
                    //просто приклеиваем кусок от root2 вместо пустоты, дальше видоизменять не нужно
                    r[0].left = r[1].left;
                }
                else
                {
                    // добавляем в стек следующую пару слева, уже слева от ТЕКУЩЕЙ левой ноды
                    stack.Push(new[] {r[0].left, r[1].left});
                }

                if (r[0].right == null)
                {
                    //просто приклеиваем кусок от roo2 вместо пустоты, дальше видоизменять не нужно
                    r[0].right = r[1].right;
                }
                else
                {
                    stack.Push(new[] {r[0].right, r[1].right});
                }
            }

            return root1;
        }

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
    }
}
