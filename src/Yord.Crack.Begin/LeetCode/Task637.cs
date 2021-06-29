using System.Collections.Generic;
using System.Linq;

namespace Yord.Crack.Begin.LeetCode
{
    //вернуть среднее на каждом уровне, The number of nodes in the tree is in the range [1, 104]
    public class Task637
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

        public static IList<double> AverageOfLevels2(TreeNode root)
        {
            var sums = new List<long[]>();
            GetSums(root, 0, sums);
            return sums.Select(s => (double) s[0] / s[1]).ToList();
        }

        private static void GetSums(TreeNode node, int level, List<long[]> sums)
        {
            if (node == null)
            {
                return;
            }

            if (sums.Count == level)
            {
                sums.Add(new long[] {node.val, 1});
            }
            else
            {
                sums[level][0] += node.val;
                sums[level][1]++;
            }

            GetSums(node.left, level + 1, sums);
            GetSums(node.right, level + 1, sums);
        }

        public static IList<double> AverageOfLevels(TreeNode root)
        {
            var res = new List<double>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root); //положили первый уровень
            while (queue.Any())
            {
                long sum = 0;
                var count = queue.Count;//сколько нод текущего уровня
                for (var i = 0; i < count; i++)
                {
                    var n = queue.Dequeue();
                    //суммируем текущий уровень, добавляя предыдущий
                    sum += n.val;
                    if (n.left != null)
                    {
                        queue.Enqueue(n.left);
                    }

                    if (n.right != null)
                    {
                        queue.Enqueue(n.right);
                    }
                    
                }
                
                res.Add((double) sum / count);
            }

            return res;
        }
    }
}
