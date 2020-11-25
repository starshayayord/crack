using System.Linq;

namespace Yord.Crack.Begin.Chapter4
{
    // создать бинарноедерево поиска с минимальной высотой
    // для отсортированного по возрастанию массива с уникальными целочисленными элементами
    public class Task2
    {
        public class BinarySearchTree
        {
            public BinarySearchTreeNode Root;

            public class BinarySearchTreeNode
            {
                public int Value;

                public BinarySearchTreeNode Left;

                public BinarySearchTreeNode Right;
            }

            public void Insert(int value)
            {
                var newNode = new BinarySearchTreeNode
                {
                    Value = value
                };
                var curNode = Root;
                while (curNode != null)
                {
                    if (value > curNode.Value)
                    {
                        if (curNode.Right == null)
                        {
                            curNode.Right = newNode;
                            return;
                        }

                        curNode = curNode.Right;
                    }
                    else
                    {
                        if (curNode.Left == null)
                        {
                            curNode.Left = newNode;
                            return;
                        }

                        curNode = curNode.Left;
                    }
                }

                Root = newNode;
            }
        }

        //PERFECT, нет take/skip. Код выглядит понятно
        public static BinarySearchTree CreateMinBST(int[] sortedArray)
        {
            return new BinarySearchTree{ Root = CreateMinBST(sortedArray, 0, sortedArray.Length - 1)};
        }

        private static BinarySearchTree.BinarySearchTreeNode CreateMinBST(int[] sortedArray, int start, int end)
        {
            if (end < start) return null;
            var mid = (start + end) / 2;
            var n = new BinarySearchTree.BinarySearchTreeNode
            {
                Value = sortedArray[mid],
                Left = CreateMinBST(sortedArray, start, mid - 1),
                Right = CreateMinBST(sortedArray, mid + 1, end)
            };
            return n;
        }
        
        public static BinarySearchTree CreateBinarySearchTree2(int[] sortedArray)
        {
            // чтобы дерево было минимальной высоты, лучше взять середину отсортированного массива за корень
            // т.к. тогда кол-во левых и правых узлов будет примерно равно
            var middleIndex = sortedArray.Length / 2;
            var bst = new BinarySearchTree
            {
                Root = new BinarySearchTree.BinarySearchTreeNode {Value = sortedArray[middleIndex]}
            };
            // а потом рекурсивно брать середину от массивов, оставшихся слева и справа середины
            AddSubArrayToTree(bst, sortedArray.Take(middleIndex).ToArray());
            AddSubArrayToTree(bst, sortedArray.Skip(middleIndex + 1).ToArray());
            return bst;
        }

        private static void AddSubArrayToTree(BinarySearchTree bst, int[] sortedArray)
        {
            if (!sortedArray.Any())
            {
                return;
            }

            var middleIndex = sortedArray.Length / 2;
            var value = sortedArray[middleIndex];
            bst.Insert(value);
            if (sortedArray.Length > 1)
            {
                AddSubArrayToTree(bst, sortedArray.Take(middleIndex).ToArray());
                AddSubArrayToTree(bst, sortedArray.Skip(middleIndex + 1).ToArray());
            }
        }
    }
}
