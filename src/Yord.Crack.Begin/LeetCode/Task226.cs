using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //отзералить бинарное дерево относительно корня
    public class Task226
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

        public TreeNode InvertTree3(TreeNode root)
        {
            if (root == null) {
                return null;
            }

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(!queue.Any()) {
                var node = queue.Dequeue();
                var left = node.left;
                node.left = node.right;
                node.right = left;

                if(node.left != null) {
                    queue.Enqueue(node.left);
                }
                if(node.right != null) {
                    queue.Enqueue(node.right);
                }
            }
            return root;
        }
        public TreeNode InvertTree2(TreeNode root)
        {
            if (root?.left == null && root?.right == null)
            {
                return root;
            }

            var left = root.left;
            root.left = InvertTree(root.right);
            root.right = InvertTree(left);
        
            return root;
        }

        public static TreeNode InvertTree(TreeNode root)
        {
            InvertTreeNode(root);
            return root;
        }

        private static void InvertTreeNode(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            var r = node.right;
            node.right = node.left;
            node.left = r;
            InvertTreeNode(node.left);
            InvertTreeNode(node.right);
        }
    }
}
