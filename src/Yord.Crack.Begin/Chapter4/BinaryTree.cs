namespace Yord.Crack.Begin.Chapter4
{
    public class BinaryTree<T>
    {
        public BinaryTreeNode Root;

        public class BinaryTreeNode
        {
            public T Value;

            public BinaryTreeNode Left;
            
            public BinaryTreeNode Right;
        }

        // симметричный обход бинарного дерева, т.е.
        // сначала все левое поддерево, потом текущий узел, потом правое поддерево
        // для дерева бинарного поиска обход происходит по возрастанию
        public void InOrderTraversal(BinaryTreeNode n)
        {
            if (n != null)
            {
                InOrderTraversal(n.Left);
                Visit(n);
                InOrderTraversal(n.Right);
            }
        }
        
        // префиксный обход бинарного дерева
        // узел посещается до его дочерних узлов
        // то есть обход начинается с помещения корневого узла
        public void PreOrderTraversal(BinaryTreeNode n)
        {
            if (n != null)
            {
                Visit(n);
                InOrderTraversal(n.Left);
                InOrderTraversal(n.Right);
            }
        }
        
        // постфиксный обход бинарного дерева
        // текущий узел посещается после дочерних
        //то есть корневой посещаем в последнюю очередь
        public void PostOrderTraversal(BinaryTreeNode n)
        {
            if (n != null)
            {
                InOrderTraversal(n.Left);
                InOrderTraversal(n.Right);
                Visit(n);
            }
        }
        private void Visit(BinaryTreeNode n)
        {
            //do smth
        }
    }
}
