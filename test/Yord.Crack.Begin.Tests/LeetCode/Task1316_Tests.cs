using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1316_Tests
    {
        [Test]
        public void Should_FindIntersection()
        {
            CollectionAssert.AreEquivalent(new[] {2}, Task1316.Intersection(new[] {1, 2, 2, 1}, new[] {2, 2}));
            CollectionAssert.AreEquivalent(new[] {9, 4}, Task1316.Intersection(new[] {4, 9, 5}, new[] {9, 4, 9, 8, 4}));
        }
    }
}
