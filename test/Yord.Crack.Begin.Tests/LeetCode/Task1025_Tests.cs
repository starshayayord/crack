using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1025_Tests
    {
        [Test]
        public void Should_DivisorGame()
        {
            Assert.IsTrue(Task1025.DivisorGame(2));
            Assert.IsFalse(Task1025.DivisorGame(3));
        }
    }
}
