using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task350_Tests
    {
        [Test]
        public void ShouldGetIntersection()
        {
            CollectionAssert.AreEquivalent(new[] {2, 2}, Task350.Intersect(new[] {1, 2, 2, 1}, new[] {2, 2}));
            CollectionAssert.AreEquivalent(new[] {4, 9}, Task350.Intersect(new[] {4, 9, 5}, new[] {9, 4, 9, 8, 4}));
        }

        [Test]
        public void ShouldGetIntersection_Sort()
        {
            CollectionAssert.AreEquivalent(new[] {2, 2}, Task350.Intersect_Sort(new[] {1, 2, 2, 1}, new[] {2, 2}));
            CollectionAssert.AreEquivalent(new[] {4, 9},
                Task350.Intersect_Sort(new[] {4, 9, 5}, new[] {9, 4, 9, 8, 4}));
        }
    }
}
