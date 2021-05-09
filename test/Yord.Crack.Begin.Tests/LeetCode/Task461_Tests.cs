using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task461_Tests
    {
        [Test]
        public void Should_HammingDistance()
        {
            Assert.AreEqual(2, Task461.HammingDistance(1, 4));
            Assert.AreEqual(1, Task461.HammingDistance(3, 1));
        }
    }
}
