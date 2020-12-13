namespace Yord.Crack.Begin.Chapter4
{
    //В бинарном дереве найти все пути, сумма значений по которым оответствует заданному числу.
    //Путь начинается/заканчивается в любом узле, но идет только вниз
    public class Task12
    {
        public static int GetAllRoutesForNumber(BTNode root, int value)
        {
            if (root == null) return 0;
            var totalRoutes = CheckNode(root, value, 0);
            totalRoutes += GetAllRoutesForNumber(root.Left, value);
            totalRoutes += GetAllRoutesForNumber(root.Right, value);
            return totalRoutes;
        }

        private static int CheckNode(BTNode node, int value, int current)
        {
            if (node == null) return 0;
            current += node.Value;
            var totalRoutes = 0;
            if (current == value) totalRoutes++;
            if (node.Left != null) totalRoutes += CheckNode(node.Left, value, current);
            if (node.Right != null) totalRoutes += CheckNode(node.Right, value, current);
            return totalRoutes;
        }

        public class BTNode
        {
            public BTNode Left;

            public BTNode Right;

            public int Value;
        }
    }
}
