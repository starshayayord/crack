using System;
using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // проверить сбалансированность бинарного дерева, т.е. разница высот двух поддеревьев любого узла <=1
    public class Task4
    {
        // PERFECT O(N)
        // рекурсивно получаем высоту левого и правого узла для каждого поддерева, пока нет ошибки (-1)
        public static bool IsBalanced(BTNode root)
        {
            return CheckHeight(root) != -1;
        }

        // спускаемся до низа левого поддерева без подсчета,  когда дошли до первой null ноды, вернем высоту 0 левого
        // идем проверять высоту правого поддерева
        // при каждом приходе в null ноду (лист) возвращаем 0
        // при каждом откате назад берем высоту максимального поддерева текущего узла и +1,
        // потому что идем на уровень выше, надо учесть высоту текущей ноды
        // возвращенную высоту левого сравниваем с рекурсивно возвращенной высотой правого
        // если разница уже дала несбалансированное дерево, то разматываем рекурсию назад с ошибочным кодом "-1"
        private static int CheckHeight(BTNode n)
        {
            if (n == null) return 0;

            var leftHeight = CheckHeight(n.Left);
            if (leftHeight == -1) return -1; //прокидывает код ошибки дальше

            var rightHeight = CheckHeight(n.Right);
            if (rightHeight == -1) return -1; //прокидывает код ошибки дальше

            if (Math.Abs(leftHeight - rightHeight) > 1) return -1; //несбалансированное, код ошибки
            return Math.Max(leftHeight, rightHeight) + 1; // возвращаем высоту поддерева
        }


        public static bool IsBalanced2(BTNode root)
        {
            if (root == null) return true;
            var lastLevels = new HashSet<int>();
            CheckLastLevels(root, 0, lastLevels);
            return lastLevels.Max() - lastLevels.Min() <= 1;
        }

        private static void CheckLastLevels(BTNode n, int level, HashSet<int> l)
        {
            if (n.Left == null)
            {
                l.Add(level);
            }
            else
            {
                CheckLastLevels(n.Left, level + 1, l);
            }

            if (n.Right == null)
            {
                l.Add(level);
            }
            else
            {
                CheckLastLevels(n.Right, level + 1, l);
            }
        }

        public class BTNode
        {
            public int Value { get; set; }

            public BTNode Left { get; set; }

            public BTNode Right { get; set; }
        }
    }
}
