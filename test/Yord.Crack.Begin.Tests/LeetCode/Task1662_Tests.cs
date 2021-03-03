using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1662_Tests
    {
        [Test]
        public void Should_CheckArrayStringsAreEqual()
        {
            Assert.IsTrue(Task1662.ArrayStringsAreEqual(new []{"ab", "c"}, new[] {"a", "bc"}));
            Assert.IsFalse(Task1662.ArrayStringsAreEqual(new []{"ac", "b"}, new[] {"a", "bc"}));
            Assert.IsTrue(Task1662.ArrayStringsAreEqual(new []{"abc", "d", "defg"}, new[] {"abcddefg"}));
            Assert.IsTrue(Task1662.ArrayStringsAreEqual(new[] {"abcddefg"}, new []{"abc", "d", "defg"} ));
            Assert.IsFalse(Task1662.ArrayStringsAreEqual(new[] {"ab", "c"}, new []{"a","bcd"} ));
        }
    }
}
