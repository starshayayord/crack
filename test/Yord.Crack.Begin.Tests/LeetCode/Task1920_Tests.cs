using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1920_Tests
    {
        [Test]
        public void Should_BuildArray()
        {
            CollectionAssert.AreEqual(new[] {0, 1, 2, 4, 5, 3}, Task1920.BuildArray(new[] {0, 2, 1, 5, 3, 4}));
            CollectionAssert.AreEqual(new[] {4, 5, 0, 1, 2, 3}, Task1920.BuildArray(new[] {5, 0, 1, 2, 3, 4}));
        }
    }
}
