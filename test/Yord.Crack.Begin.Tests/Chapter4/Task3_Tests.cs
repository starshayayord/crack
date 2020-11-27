using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task3_Tests
    {
        [Test]
        public void Should_ConvertTree2_Successfully()
        {
            var t = GetTree();

            var list = Task3.ConvertToLists2(t);
        }
        
        private Task3.BinaryTree GetTree()
        {
            var t = new Task3.BinaryTree
            {
                Root = new Task3.BinaryTreeNode
                {
                    Value = 1,
                    Left = new Task3.BinaryTreeNode
                    {
                        Value = 2,
                        Left = new Task3.BinaryTreeNode {Value = 4, Left = new Task3.BinaryTreeNode {Value = 7}},
                        Right = new Task3.BinaryTreeNode {Value = 5}
                    },
                    Right = new Task3.BinaryTreeNode
                    {
                        Value = 3,
                        Left = new Task3.BinaryTreeNode {Value = 6}
                    }
                }
            };
            return t;
        }
    }
}
