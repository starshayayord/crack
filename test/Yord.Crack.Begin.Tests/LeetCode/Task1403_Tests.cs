using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1403_Tests
    {
        [Test]
        public void Should_MinSubsequence()
        {
            CollectionAssert.AreEquivalent(new[] {10, 9}, Task1403.MinSubsequence(new[] {4, 3, 10, 9, 8,}));
            CollectionAssert.AreEquivalent(new[] {7, 7, 6}, Task1403.MinSubsequence(new[] {4, 4, 7, 6, 7}));
            CollectionAssert.AreEquivalent(new[] {6}, Task1403.MinSubsequence(new[] {6}));
        }
    }
}
