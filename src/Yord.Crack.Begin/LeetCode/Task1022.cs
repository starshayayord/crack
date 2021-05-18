namespace Yord.Crack.Begin.LeetCode
{
    public class Task1022
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

        public class Solution
        {
            public int SumRootToLeaf(TreeNode root)
            {
                return Traverse(root, 0);
            }

            private int Traverse(TreeNode node, int r)
            {
                if (node == null)
                {
                    return 0;
                }

                //сдвигаем сумму уже просчитанного пути на разряд
                r = r * 2 + node.val;
                //если лист, то возвращаем полученную сумму, иначе нужно сложить путь слева и путь справа
                return node.left == null && node.right == null
                    ? r
                    : Traverse(node.left, r) + Traverse(node.right, r);
            }
        }
    }
}
