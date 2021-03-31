using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task575_Tests
    {
        [Test]
        public void Should_DistributeCandies()
        {
            Assert.AreEqual(3, Task575.DistributeCandies(new[] {1, 1, 2, 2, 3, 3}));
            Assert.AreEqual(2, Task575.DistributeCandies(new[] {1, 1, 2, 3}));
            Assert.AreEqual(1, Task575.DistributeCandies(new[] {6, 6, 6, 6}));
        }
    }
}
