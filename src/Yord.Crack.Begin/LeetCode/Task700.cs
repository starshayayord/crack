namespace Yord.Crack.Begin.LeetCode
{
    public class Task700
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


        public TreeNode SearchBSTRec(TreeNode root, int val)
        {
            if (root == null || root.val == val)
            {
                return root;
            }

            if (root.val > val)
            {
                return SearchBSTRec(root.left, val);
            }

            return SearchBSTRec(root.right, val);
        }

        public TreeNode SearchBSTIter(TreeNode root, int val)
        {
            while (true)
            {
                if (root == null || root.val == val)
                {
                    return root;
                }

                if (root.val > val)
                {
                    root = root.left;
                    continue;
                }

                root = root.right;
            }
        }
    }
}
