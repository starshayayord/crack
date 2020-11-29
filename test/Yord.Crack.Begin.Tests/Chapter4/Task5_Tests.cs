using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task5_Tests
    {
        [Test]
        public void Should_CheckIfBst_WhenMinMax()
        {
            Assert.IsFalse(Task5.IsBSTMinMax(GetNotBST()));
            Assert.IsTrue(Task5.IsBSTMinMax(GetBST()));
        }
        
        [Test]
        public void Should_CheckIfBst_WhenInOrderTraversal()
        {
            Assert.IsFalse(Task5.IsBSTInOrderTraversal(GetNotBST()));
            Assert.IsTrue(Task5.IsBSTInOrderTraversal(GetBST()));
        }
        
        private Task5.BTNode GetBST()
        {
            return new Task5.BTNode
            {
                Value = 10,
                Left = new Task5.BTNode {Value = 4, Left = new Task5.BTNode {Value = 2}},
                Right = new Task5.BTNode {Value = 11}
            };
        }

        private Task5.BTNode GetNotBST()
        {
            return new Task5.BTNode
            {
                Value = 20,
                Left = new Task5.BTNode {Value = 10, Right = new Task5.BTNode {Value = 25}},
                Right = new Task5.BTNode {Value = 30}
            };
        }
    }
}
