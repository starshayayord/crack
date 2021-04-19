using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1261_Tests
    {
        [Test]
        public void Should_FindElements()
        {
            var s1 = new Task1261.TreeNode(-1, null, new Task1261.TreeNode(-1));
            var f1 = new Task1261.FindElements(s1);
            Assert.IsFalse(f1.Find(1));
            Assert.IsTrue(f1.Find(2));

            var s2 = new Task1261.TreeNode(-1,
                new Task1261.TreeNode(-1, new Task1261.TreeNode(-1), new Task1261.TreeNode(-1)),
                new Task1261.TreeNode(-1));
            var f2 = new Task1261.FindElements(s2);
            Assert.IsTrue(f2.Find(1));
            Assert.IsTrue(f2.Find(3));
            Assert.IsFalse(f2.Find(5));

            var s3 = new Task1261.TreeNode(-1, null,
                new Task1261.TreeNode(-1, new Task1261.TreeNode(-1, new Task1261.TreeNode(-1))));
            var f3 = new Task1261.FindElements(s3);
            Assert.IsTrue(f3.Find(2));
            Assert.IsFalse(f3.Find(3));
            Assert.IsFalse(f3.Find(4));
            Assert.IsTrue(f3.Find(5));
        }
    }
}
