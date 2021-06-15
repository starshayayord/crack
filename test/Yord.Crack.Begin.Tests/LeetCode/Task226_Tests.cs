using System.Threading.Tasks;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task226_Tests
    {
        [Test]
        public void Should_InvertTree()
        {
            var tree = new Task226.TreeNode(4,
                new Task226.TreeNode(2, new Task226.TreeNode(1), new Task226.TreeNode(3)),
                new Task226.TreeNode(7, new Task226.TreeNode(6), new Task226.TreeNode(9)));
            Task226.InvertTree(tree);
        }
    }
}
