namespace Yord.Crack.Begin.Chapter4
{
    // проверить является ли бинарное дерево деревом поиска
    // все значения уникальны
    public class Task5
    {
        public static bool IsBSTMinMax(BTNode root)
        {
            return IsBSTMinMax(root, null, null);
        }
        
        public static bool IsBSTMinMax(BTNode node, int? min, int? max)
        {
            if (node == null) return true;
            if (min.HasValue && min > node.Value || max.HasValue && max < node.Value) return false;
            return IsBSTMinMax(node.Left, min, node.Value) && IsBSTMinMax(node.Right, node.Value, max);
        }
        public static bool IsBSTInOrderTraversal(BTNode root)
        {
            int? lastValue = null;
            return IsBSTInOrderTraversal(root, ref lastValue);
        }

        private static bool IsBSTInOrderTraversal(BTNode root, ref int? lastValue)
        {
            if (root != null)
            {
                if (!IsBSTInOrderTraversal(root.Left, ref lastValue)) return false;
                // сначала last - это минимальный левый
                // после проверки, перед подъемом назад по рекурсии - правый
                // то т.к. мы выходим и поднимаемся выше, то сверять его будем с узлом на уровень выше
                //  Т.Е. текущий > чем его левый
                // а потом текущий больше, чем самый большой из тех, что через один узел ниже
                if (lastValue.HasValue && root.Value <= lastValue.Value) return false;

                lastValue = root.Value;
                if (!IsBSTInOrderTraversal(root.Right, ref lastValue)) return false;
            }

            return true;
        }

        public class BTNode
        {
            public int Value { get; set; }

            public BTNode Left { get; set; }

            public BTNode Right { get; set; }
        }
    }
}
