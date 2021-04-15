using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task205_Tests
    {
        [Test]
        public void Should_IsIsomorphic()
        {
            Assert.IsTrue(Task205.IsIsomorphic("egg", "add"));
            Assert.IsFalse(Task205.IsIsomorphic("foo", "bar"));
            Assert.IsTrue(Task205.IsIsomorphic("paper", "title"));
            Assert.IsFalse(Task205.IsIsomorphic("badc", "bada"));
            Assert.IsFalse(Task205.IsIsomorphic("bbbaaaba", "aaabbbba"));
        }
    }
}
