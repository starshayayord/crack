using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1822_Tests
    {
        [Test]
        public void Should_ArraySign()
        {
            Assert.AreEqual(1, Task1822.ArraySign(new[] {-1, -2, -3, -4, 3, 2, 1}));
            Assert.AreEqual(0, Task1822.ArraySign(new[] {1, 5, 0, 2, -3}));
            Assert.AreEqual(-1, Task1822.ArraySign(new[] {-1, 1, -1, 1, -1}));
        }
    }
}
