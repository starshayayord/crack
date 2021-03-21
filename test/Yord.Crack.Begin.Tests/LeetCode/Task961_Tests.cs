using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task961_Tests
    {
        [Test]
        public void Should_RepeatedNTimes()
        {
            Assert.AreEqual(3, Task961.RepeatedNTimes(new[] {1, 2, 3, 3}));
            Assert.AreEqual(2, Task961.RepeatedNTimes(new[] {2, 1, 2, 5, 3, 2}));
            Assert.AreEqual(5, Task961.RepeatedNTimes(new[] {5, 1, 5, 2, 5, 3, 5, 4}));
        }
    }
}
