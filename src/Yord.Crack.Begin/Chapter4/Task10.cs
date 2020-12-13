namespace Yord.Crack.Begin.Chapter4
{
    // T1 >> T2 проверить, является ли бинарное дерево T2 поддеревом бинарного дерева T1
    public class Task10
    {
        public static bool IsSubTree(BTNode t1, BTNode t2)
        {
            if (t2 == null) return true;
            return SubTree(t1, t2);
        }

        //сравниваем узлы t1 последовательно с t2, пока не найдем совпадающее значение
        private static bool SubTree(BTNode t1, BTNode t2)
        {
            if (t1 == null) return false;
            //когда нашли совпадающее значение, то сравниваем деревья
            if (t1.Value == t2.Value && MatchTree(t1, t2)) return true;
            return SubTree(t1.Left, t2) || SubTree(t1.Right, t2);
        }

        private static bool MatchTree(BTNode t1, BTNode t2)
        {
            //дошли до конца поддерева
            if (t1 == null && t2 == null) return true;
            //одно из деревьев кончилось
            if (t1 == null || t2 == null) return false;
            //нет совпадения
            if (t1.Value != t2.Value) return false;
            //пока всё совпало, проверим левую и правую часть на совпадение
            return MatchTree(t1.Left, t2.Left) && MatchTree(t1.Right, t2.Right);
        }
        public class BTNode
        {
            public int Value;
            public BTNode Left;
            public BTNode Right;
        }
    }
}
