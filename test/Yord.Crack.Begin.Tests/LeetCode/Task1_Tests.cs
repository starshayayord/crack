using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_TwoSum()
        {
            CollectionAssert.AreEquivalent(new[] {0, 1}, Task1.TwoSum(new[] {2, 7, 11, 15}, 9));
            CollectionAssert.AreEquivalent(new[] {1, 2}, Task1.TwoSum(new[] {3, 2, 4}, 6));
            CollectionAssert.AreEquivalent(new[] {0, 1}, Task1.TwoSum(new[] {3, 3}, 6));
        }
    }
}
