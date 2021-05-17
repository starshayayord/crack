using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task977_Tests
    {
        [Test]
        public void Should_SortedSquares()
        {
            CollectionAssert.AreEqual(new[] {1, 4, 9, 25}, Task977.SortedSquares(new[] {-5, -3, -2, -1}));
            CollectionAssert.AreEqual(new[] {1, 4, 9, 25}, Task977.SortedSquares(new[] {1, 2, 3, 5}));
            CollectionAssert.AreEqual(new[] {0, 1, 9, 16, 100}, Task977.SortedSquares(new[] {-4, -1, 0, 3, 10}));
            CollectionAssert.AreEqual(new[] {4, 9, 9, 49, 121}, Task977.SortedSquares(new[] {-7, -3, 2, 3, 11}));
        }
    }
}
