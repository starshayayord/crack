using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task645_Tests
    {
        [Test]
        public void Should_FindErrorNums()
        {
            CollectionAssert.AreEqual(new[] {2, 1}, Task645.FindErrorNums(new[] {3, 2, 2}));
            CollectionAssert.AreEqual(new[] {2, 1}, Task645.FindErrorNums(new[] {2, 2}));
            CollectionAssert.AreEqual(new[] {2, 3}, Task645.FindErrorNums(new[] {1, 2, 2, 4}));
            CollectionAssert.AreEqual(new[] {1, 2}, Task645.FindErrorNums(new[] {1, 1}));
            CollectionAssert.AreEqual(new[] {2, 1}, Task645.FindErrorNums(new[] {2, 3, 2}));
            CollectionAssert.AreEqual(new[] {3, 2}, Task645.FindErrorNums(new[] {3, 3, 1}));
        }
    }
}
