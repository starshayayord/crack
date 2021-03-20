using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task897_Tests
    {
        [Test]
        public void Should_RearrangeTree()
        {
            var t = new Task897.TreeNode(5,
                new Task897.TreeNode(3, new Task897.TreeNode(2, new Task897.TreeNode(1)), new Task897.TreeNode(4)),
                new Task897.TreeNode(6, null,
                    new Task897.TreeNode(8, new Task897.TreeNode(7), new Task897.TreeNode(9))));
            var inc = Task897.IncreasingBST(t);
        }
    }
}
