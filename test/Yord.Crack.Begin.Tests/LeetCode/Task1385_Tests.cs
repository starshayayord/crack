using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1385_Tests
    {
        [Test]
        public void Should_()
        {
            Assert.AreEqual(2, Task1385.FindTheDistanceValue(new[] {4, 5, 8}, new[] {10, 9, 1, 8}, 2));
            Assert.AreEqual(2, Task1385.FindTheDistanceValue(new[] {1, 4, 2, 3}, new[] {-4, -3, 6, 10, 20, 30}, 3));
            Assert.AreEqual(1, Task1385.FindTheDistanceValue(new[] {2, 1, 100, 3}, new[] {-5, -2, 10, -3, 7}, 6));
        }
    }
}
