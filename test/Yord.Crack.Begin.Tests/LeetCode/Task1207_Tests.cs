using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1207_Tests
    {
        [Test]
        public void Should_UniqueOccurrences()
        {
            Assert.IsTrue(Task1207.UniqueOccurrences(new[] {1, 2, 2, 1, 1, 3}));
            Assert.IsFalse(Task1207.UniqueOccurrences(new[] {1, 2}));
            Assert.IsTrue(Task1207.UniqueOccurrences(new[] {-3, 0, 1, -3, 1, 1, 1, -3, 10, 0}));
        }
    }
}
