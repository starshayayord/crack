using System.Collections.Generic;

namespace Yord.Crack.Begin.Chapter4
{
    //В бинарном дереве найти все пути, сумма значений по которым оответствует заданному числу.
    //Путь начинается/заканчивается в любом узле, но идет только вниз
    public class Task12
    {
        public static int GetAllRoutesForNumber(BTNode root, int target)
        {
            return CheckNode(root, target, 0, new Dictionary<int, int>());
        }

        private static int CheckNode(BTNode node, int target, int current, Dictionary<int, int> pathCount)
        {
            if (node == null) return 0;
            /* подсчет путей, заканчивающихся на текущием узле, с нужной суммой*/
            current += node.Value;
            var sum = current - target;
            var totalPaths = pathCount.GetValueOrDefault(sum);
            
            if (current == target) totalPaths++; //значит есть доп. путь от корня
            
            ChangeTable(pathCount, current, 1);//добавим текущую сумму и увеличм кол-во путей ее достижения на 1
            
            totalPaths += CheckNode(node.Left, target, current, pathCount);
            totalPaths += CheckNode(node.Right, target, current, pathCount);
            //отменим изменение в хэш таблице при возврате, чтоб другие узлы их не использовали (идем назад вверх)
            
            ChangeTable(pathCount, current, -1); 
            return totalPaths;
        }

        private static void ChangeTable(Dictionary<int, int> pathCount, int key, int delta)
        {
            var count = pathCount.GetValueOrDefault(key) + delta;
            if (count == 0)
            {
                pathCount.Remove(key); //нет смысла держать значение с нулевым кол-вом путей
            }
            else
            {
                pathCount[key] = count;
            }
        }

        public static int GetAllRoutesForNumber2(BTNode root, int value)
        {
            if (root == null) return 0;
            var totalRoutes = CheckNode(root, value, 0);
            totalRoutes += GetAllRoutesForNumber2(root.Left, value);
            totalRoutes += GetAllRoutesForNumber2(root.Right, value);
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
