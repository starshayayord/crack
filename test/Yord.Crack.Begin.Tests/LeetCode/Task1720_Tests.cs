using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1720_Tests
    {
        [Test]
        public void Should_DecodeArray()
        {
            CollectionAssert.AreEqual(new[] {1, 0, 2, 1}, Task1720.Decode(new[] {1, 2, 3}, 1));
            CollectionAssert.AreEqual(new[] {4, 2, 0, 7, 4}, Task1720.Decode(new[] {6, 2, 7, 3}, 4));
        }
    }
}
