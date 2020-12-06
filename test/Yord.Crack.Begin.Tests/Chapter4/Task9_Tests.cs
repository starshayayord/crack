using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task9_Tests
    {
        [Test]
        public void Should_GetInitial_Tree()
        {
            var tree = GetTree();

            var result = Task9.GetInitialArrays(tree);
            
            Assert.AreEqual(80, result.Count);
        }

        private Task9.BSTNode GetTree()
        {
            return new Task9.BSTNode
            {
                Value = 4,
                Left = new Task9.BSTNode {Value = 2, Left = new Task9.BSTNode {Value = 1}, Right = new Task9.BSTNode{Value = 3}},
                Right = new Task9.BSTNode {Value = 6, Left = new Task9.BSTNode {Value = 5}, Right = new Task9.BSTNode{Value = 7}}
            };
        }
    }
}
