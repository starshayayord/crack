using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    // Дано BST. Вернуть сумму значений в диапазоне (включительно)
    public class Task938
    {
        public static int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null) return 0;
            // если нода больше большего, то подходящее мб только слева
            if (root.val > high) return RangeSumBST(root.left, low, high);
            // если нода меньше меньшего, то подходящее мб только справа
            if (root.val < low) return RangeSumBST(root.right, low, high);
            //если нода в диапазоне, то нужно сложить текущую и сумму по левой и правой
            return RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high) + root.val;
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
