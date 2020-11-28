using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task4_Tests
    {
        [Test]
        public void Should_CheckIfBalanced_Successfully()
        {
            Assert.IsFalse(Task4.IsBalanced(GetNotBalanced()));
            Assert.IsTrue(Task4.IsBalanced(GetBalanced()));
        }
        
        [Test]
        public void Should_CheckIfBalanced2_Successfully()
        {
            Assert.IsFalse(Task4.IsBalanced2(GetNotBalanced()));
            Assert.IsTrue(Task4.IsBalanced2(GetBalanced()));
        }

        private Task4.BTNode GetBalanced()
        {
            return new Task4.BTNode
            {
                Value = 1,
                Left = new Task4.BTNode {Value = 2, Left = new Task4.BTNode {Value = 4}},
                Right = new Task4.BTNode {Value = 3}
            };
        }

        private Task4.BTNode GetNotBalanced()
        {
            return new Task4.BTNode
            {
                Value = 1,
                Left = new Task4.BTNode
                    {Value = 2, Left = new Task4.BTNode {Value = 4, Left = new Task4.BTNode {Value = 5}}},
                Right = new Task4.BTNode {Value = 3}
            };
        }
    }
}
