using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1719_Tests
    {
        [Test]
        public void Should_FindCenter()
        {
            Assert.AreEqual(2, Task1719.FindCenter(new[] {new[] {1, 2}, new[] {2, 3}, new[] {4, 2}}));
            Assert.AreEqual(1, Task1719.FindCenter(new[] {new[] {1, 2}, new[] {5, 1}, new[] {1, 3}, new[] {1, 4}}));
        }
    }
}
