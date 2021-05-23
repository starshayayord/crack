using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1441_Tests
    {
        [Test]
        public void Should_BuildArray()
        {
            CollectionAssert.AreEqual(new[] {"Push", "Push", "Pop", "Push"}, Task1441.BuildArray(new[] {1, 3}, 3));
            CollectionAssert.AreEqual(new[] {"Push", "Push", "Push"}, Task1441.BuildArray(new[] {1, 2, 3}, 3));
            CollectionAssert.AreEqual(new[] {"Push", "Push"}, Task1441.BuildArray(new[] {1, 2}, 4));
            CollectionAssert.AreEqual(new[] {"Push", "Pop", "Push", "Push", "Push"},
                Task1441.BuildArray(new[] {2, 3, 4}, 4));
        }
    }
}
