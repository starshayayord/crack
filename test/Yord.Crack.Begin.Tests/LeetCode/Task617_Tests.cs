using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task617_Tests
    {
        [Test]
        public void Should_MergeTrees()
        {
            var root1 = new Task617.TreeNode(1, new Task617.TreeNode(3, new Task617.TreeNode(5)),
                new Task617.TreeNode(2));
            var root2 = new Task617.TreeNode(2, new Task617.TreeNode(1, null, new Task617.TreeNode(4)),
                new Task617.TreeNode(3, null, new Task617.TreeNode(7)));

            var r = Task617.MergeTrees(root1, root2);
        }
        
        [Test]
        public void Should_MergeTrees_2()
        {
            var root1 = new Task617.TreeNode(1);
            var root2 = new Task617.TreeNode(1, new Task617.TreeNode(2));
            var r = Task617.MergeTrees(root1, root2);
        }
    }
}
