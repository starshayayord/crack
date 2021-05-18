using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1022_Tests
    {
        [Test]
        public void Should_SumRootToLeaf()
        {
            var s0 = new Task1022.Solution();
            Assert.AreEqual(2, s0.SumRootToLeaf(new Task1022.TreeNode(1, null, new Task1022.TreeNode(0))));
            
            var s1 = new Task1022.Solution();
            Assert.AreEqual(22, s1.SumRootToLeaf(new Task1022.TreeNode(1,
                new Task1022.TreeNode(0, new Task1022.TreeNode(0), new Task1022.TreeNode(1)),
                new Task1022.TreeNode(1, new Task1022.TreeNode(0), new Task1022.TreeNode(1)))));

            var s2 = new Task1022.Solution();
            Assert.AreEqual(0, s2.SumRootToLeaf(new Task1022.TreeNode(0)));

            var s3 = new Task1022.Solution();
            Assert.AreEqual(1, s3.SumRootToLeaf(new Task1022.TreeNode(1)));

            var s4 = new Task1022.Solution();
            Assert.AreEqual(3, s4.SumRootToLeaf(new Task1022.TreeNode(1, new Task1022.TreeNode(1))));
        }
    }
}
