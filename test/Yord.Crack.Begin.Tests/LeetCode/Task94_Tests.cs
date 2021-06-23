using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task94_Tests
    {
        [Test]
        public void Should_InOrderTraversal()
        {
            CollectionAssert.AreEqual(new[] {1, 3, 2},
                Task94.InorderTraversal(new Task94.TreeNode(1, null, new Task94.TreeNode(2, new Task94.TreeNode(3)))));
            CollectionAssert.AreEqual(new int[0], Task94.InorderTraversal(null));
            CollectionAssert.AreEqual(new[] {2, 1},
                Task94.InorderTraversal(new Task94.TreeNode(1, new Task94.TreeNode(2))));
            CollectionAssert.AreEqual(new[] {1, 2},
                Task94.InorderTraversal(new Task94.TreeNode(1, null, new Task94.TreeNode(2))));
        }
        
        [Test]
        public void Should_InOrderTraversal2()
        {
            CollectionAssert.AreEqual(new[] {1, 3, 2},
                Task94.InorderTraversal2(new Task94.TreeNode(1, null, new Task94.TreeNode(2, new Task94.TreeNode(3)))));
            CollectionAssert.AreEqual(new int[0], Task94.InorderTraversal2(null));
            CollectionAssert.AreEqual(new[] {2, 1},
                Task94.InorderTraversal2(new Task94.TreeNode(1, new Task94.TreeNode(2))));
            CollectionAssert.AreEqual(new[] {1, 2},
                Task94.InorderTraversal2(new Task94.TreeNode(1, null, new Task94.TreeNode(2))));
        }
    }
}
