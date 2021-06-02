using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1710_Tests
    {
        [Test]
        public void Should_MaximumUnits()
        {
            Assert.AreEqual(8, Task1710.MaximumUnits(new[]
            {
                new[] {1, 3}, new[] {2, 2}, new[] {3, 1}
            }, 4));

            Assert.AreEqual(91, Task1710.MaximumUnits(new[]
            {
                new[] {5, 10}, new[] {2, 5}, new[] {4, 7}, new[] {3, 9}
            }, 10));
        }
    }
}
