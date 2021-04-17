using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task290_Tests
    {
        [Test]
        public void Should_WordPattern()
        {
            Assert.IsTrue(Task290.WordPattern("abba", "dog cat cat dog"));
            Assert.IsFalse(Task290.WordPattern("abba", "dog cat cat fish"));
            Assert.IsFalse(Task290.WordPattern("aaaa", "dog cat cat dog"));
            Assert.IsFalse(Task290.WordPattern("abba", "dog dog dog dog"));
        }
    }
}
