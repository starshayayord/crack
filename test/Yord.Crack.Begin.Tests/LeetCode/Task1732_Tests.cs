using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1732_Tests
    {
        [Test]
        public void Should_GetLargestAltitude()
        {
            Assert.AreEqual(1, Task1732.LargestAltitude(new[] {-5, 1, 5, 0, -7}));
            Assert.AreEqual(0, Task1732.LargestAltitude(new[] {-4, -3, -2, -1, 4, 3, 2}));
        }
    }
}
