using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1413_Tests
    {
        [Test]
        public void Should_MinStartValue()
        {
            Assert.AreEqual(5, Task1413.MinStartValue(new []{-3,2,-3,4,2}));
            Assert.AreEqual(1, Task1413.MinStartValue(new []{1,2}));
            Assert.AreEqual(5, Task1413.MinStartValue(new []{1,-2,-3}));
        }
    }
}
