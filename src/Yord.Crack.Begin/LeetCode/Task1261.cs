using System.Collections.Generic;

namespace Yord.Crack.Begin.LeetCode
{
    // root=0
    //treeNode.val == x and treeNode.left != null => treeNode.left.val == 2 * x + 1
    //treeNode.val == x and treeNode.right != null => treeNode.right.val == 2 * x + 2
    //значения были заменены на -1. Восстановить исходное
    // вернуть true, если заданный элемент есть в дереве
    public class Task1261
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

        public class FindElements
        {
            private HashSet<int> values = new HashSet<int>();

            public FindElements(TreeNode root)
            {
                Recover(0, root);
            }

            public bool Find(int target)
            {
                return values.Contains(target);
            }

            private void Recover(int val, TreeNode node)
            {
                values.Add(val);
                val <<= 1;
                if (node.left != null)
                {
                    Recover(val + 1, node.left);
                }

                if (node.right != null)
                {
                    Recover(val + 2, node.right);
                }
            }
        }
    }
}
