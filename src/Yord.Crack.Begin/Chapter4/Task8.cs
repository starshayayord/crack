namespace Yord.Crack.Begin.Chapter4
{
    // найти первого общего предка двух узлов бинарного дерева, не использовать дополнительные структуры данных
    public class Task8
    {
        public static BTNode GetAncestor(BTNode root, BTNode n1, BTNode n2)
        {
            var r = FirstAncestor(root, n1, n2);
            return r.IsAncestor ? r.Node : null;
        }


        private static Ancestor FirstAncestor(BTNode root, BTNode n1, BTNode n2)
        {
            if (root == null) return new Ancestor(false); // дошли до низа безуспешно
            // нода равна сразу обоим узлам, возвращаем этот узел
            if (root == n1 && root == n2) return new Ancestor(true, root); 
            // ищем предка слева
            var rl = FirstAncestor(root.Left, n1, n2);
            if (rl.IsAncestor) return rl;
            // ищем предка справа
            var rr = FirstAncestor(root.Right, n1, n2);
            if (rr.IsAncestor) return rr;
            // в каждом из поддеревьев есть по одной ноде, значит текущий - искомый предок
            if (rl.Node != null && rr.Node != null)
            {
                return new Ancestor(true, root);
            }
            // текущий узел равен одному из тех, у которых ищем родителя
            // значит мы нашли как минимум родителя одного из узлов
            // или обоих, если нашли по ноде в поддереве
            if (root == n1 || root == n2)
            {
                return new Ancestor(rl.Node != null || rr.Node != null, root);
            }

            // родителя не нашли, ненулевую ноду запоминаем
            return new Ancestor(false, rl.Node ?? rr.Node);
        }


        private class Ancestor
        {
            public BTNode Node;
            public bool IsAncestor;

            public Ancestor(bool isAncestor, BTNode node = null)
            {
                Node = node;
                IsAncestor = isAncestor;
            }
        }

        public class BTNode
        {
            public int Value;
            public BTNode Left;
            public BTNode Right;
        }
    }
}
