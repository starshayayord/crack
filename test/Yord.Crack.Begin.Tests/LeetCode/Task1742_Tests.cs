using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1742_Tests
    {
        [Test]
        public void Should_CountBalls()
        {
            Assert.AreEqual(2, Task1742.CountBalls(1, 10));
            Assert.AreEqual(2, Task1742.CountBalls(5, 15));
            Assert.AreEqual(2, Task1742.CountBalls(19, 28));
        }
    }
}
