using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1816_Tests
    {
        [Test]
        public void Should_TruncateSentence()
        {
            Assert.AreEqual("Hello how are you", Task1816.TruncateSentence("Hello how are you Contestant",4));
            Assert.AreEqual("What is the solution", Task1816.TruncateSentence("What is the solution to this problem",4));
            Assert.AreEqual("chopper is not a tanuki", Task1816.TruncateSentence("chopper is not a tanuki",5));
        }
    }
}
