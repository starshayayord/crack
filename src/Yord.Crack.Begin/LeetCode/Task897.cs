namespace Yord.Crack.Begin.LeetCode
{
    //отсортировать дерево в возрастающем порядке
    public class Task897
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

        public static TreeNode IncreasingBST(TreeNode root)
        {
            return InOrder(root, null);
        }

        // Обходим в порядке левое поддерево, нода, правое поддерево
        // next - следующая нода в 
        private static TreeNode InOrder(TreeNode node, TreeNode next)
        {
            //если текущая нода равна нулю, то возвращаем следующую в обходе, т.е.
            // для самой левой ноды  - ее родителя
            // для правой - родитель ее родителя
            if (node == null) 
            {
                return next;
            }

            //идем до самой левой, запоминая следующую в обходе (ее родителя),
            //т.е. в каждую новую итерацию передаем левую ноду и текущую
            TreeNode r = InOrder(node.left, node);//т.е. взяли меньшую как голову
            node.left = null;// у текущей ноды убираем левую - она уже стала головой 
            //для текущей ноды правой будет либо ее правая, либо ее родитель,
            //т.е. в каждую новую итерацию передаем правую ноду и родителя текущей. 
            //если в правом поддереве только правые ноды, то  next не будет меняться несколько итераций
            node.right = InOrder(node.right, next);
            return r;//возвращаем полученную ноду
        }
    }
}
