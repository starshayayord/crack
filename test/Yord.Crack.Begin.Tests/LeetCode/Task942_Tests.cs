using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task942_Tests
    {
        [Test]
        public void Should_DiStringMatch()
        {
            CollectionAssert.AreEqual(new[] {0, 4, 1, 3, 2}, Task942.DiStringMatch("IDID"));
            CollectionAssert.AreEqual(new[] {0, 1, 2, 3}, Task942.DiStringMatch("III"));
            CollectionAssert.AreEqual(new[] {3, 2, 0, 1}, Task942.DiStringMatch("DDI"));
        }
    }
}
