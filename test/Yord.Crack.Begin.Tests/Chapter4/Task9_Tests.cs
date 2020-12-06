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
            
            Assert.AreEqual(2, result.Count);
            CollectionAssert.AreEqual(new [] {2, 1, 3}, result[0]);
            CollectionAssert.AreEqual(new [] {2, 3, 1}, result[1]);
        }

        private Task9.BSTNode GetTree()
        {
            return new Task9.BSTNode
            {
                Value = 2,
                Left = new Task9.BSTNode {Value = 1},
                Right = new Task9.BSTNode {Value = 3}
            };
        }
    }
}
