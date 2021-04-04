using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task389_Tests
    {
        [Test]
        public void Should_FindDiff_Arr()
        {
            Assert.AreEqual('e', Task389.FindTheDifference_Arr("abcd", "abcde"));
            Assert.AreEqual('y', Task389.FindTheDifference_Arr("", "y"));
            Assert.AreEqual('a', Task389.FindTheDifference_Arr("a", "aa"));
            Assert.AreEqual('a', Task389.FindTheDifference_Arr("ae", "aea"));
        }
        
        [Test]
        public void Should_FindDiff_Dict()
        {
            Assert.AreEqual('e', Task389.FindTheDifference_Dict("abcd", "abcde"));
            Assert.AreEqual('y', Task389.FindTheDifference_Dict("", "y"));
            Assert.AreEqual('a', Task389.FindTheDifference_Dict("a", "aa"));
            Assert.AreEqual('a', Task389.FindTheDifference_Dict("ae", "aea"));
        }
    }
}
