using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task908_Tests
    {
        [Test]
        public void Should_SmallestRangeI()
        {
            Assert.AreEqual(6, Task908.SmallestRangeI(new[] {0, 10}, 2));
            Assert.AreEqual(0, Task908.SmallestRangeI(new[] {1}, 0));
            Assert.AreEqual(0, Task908.SmallestRangeI(new[] {1, 3, 6}, 3));
        }
    }
}
