namespace Yord.Crack.Begin.LeetCode
{
    //вернуть, имеют ли все ноды одинаковое значение
    public class Task965
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

            public bool IsUnivalTree(TreeNode root)
            {
                return IsUnivalTree(root, root.val);
            }

            private bool IsUnivalTree(TreeNode root, int val)
            {
                if (root == null) return true;
                if (root.val != val)
                {
                    return false;
                }

                return IsUnivalTree(root.left, val) && IsUnivalTree(root.right, val);
            }
        }
    }
}
