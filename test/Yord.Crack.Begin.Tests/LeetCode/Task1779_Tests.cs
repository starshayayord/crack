using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1779_Tests
    {
        [Test]
        public void Should_NearestValidPoint()
        {
            Assert.AreEqual(2, Task1779.NearestValidPoint(3, 4,
                new[] {new[] {1, 2}, new[] {3, 1}, new[] {2, 4}, new[] {2, 3}, new[] {4, 4}}));

            Assert.AreEqual(0, Task1779.NearestValidPoint(3, 4, new[] {new[] {3, 4}}));
            Assert.AreEqual(-1, Task1779.NearestValidPoint(3, 4, new[] {new[] {2, 3}}));
        }
    }
}
