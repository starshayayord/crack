using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1200_Tests
    {
        [Test]
        public void Should_MinimumAbsDifference()
        {
            CollectionAssert.AreEqual(new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}},
                Task1200.MinimumAbsDifference(new[] {4, 2, 1, 3}));
            CollectionAssert.AreEqual(new[] {new[] {1, 3},},
                Task1200.MinimumAbsDifference(new[] {1, 3, 6, 10, 15}));
            CollectionAssert.AreEqual(new[] {new[] {-14, -10}, new[] {19, 23}, new[] {23, 27}},
                Task1200.MinimumAbsDifference(new[] {3, 8, -10, 23, 19, -4, -14, 27}));
        }
    }
}
