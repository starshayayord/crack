namespace Yord.Crack.Begin.Chapter4
{
    // поиск следующего узла в бинарном дереве. У каждого узла есть ссылка на его родителя.
    // пор]док обхода: left, current, right
    public class Task6
    {
        //PERFECT
        public static BTNode GetNext(BTNode n)
        {
            if (n == null) return null;
            // если есть правое поддерево, то следующий будет нижний левый узел из него
            if (n.Right != null) return GetLeftBottom(n.Right);
            var c = n;
            var p = n.Parent;
            // поднимаемся, пока не окажемся слева, тогда следующий будет текущий (родитель левого)
            while (p!= null && p.Left!=c)
            {
                c = p;
                p = p.Parent;
            }

            return p;
        }

        private static BTNode GetLeftBottom(BTNode n)
        {
            while (n?.Left != null)
            {
                n = n.Left;
            }

            return n;
        }

        public class BTNode
        {
            public int Value;
            public BTNode Right;
            public BTNode Left;
            public BTNode Parent;
        }
    }
}
