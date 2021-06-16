using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1880_Tests
    {
        [Test]
        public void Should_CheckSum()
        {
            Assert.IsTrue(Task1880.IsSumEqual("acb", "cba", "cdb"));
            Assert.IsFalse(Task1880.IsSumEqual("aaa", "a", "aab"));
            Assert.IsTrue(Task1880.IsSumEqual("aaa", "a", "aaaa"));
        }
    }
}
