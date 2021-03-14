using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1450_Tests
    {
        [Test]
        public void Should_CountBusy()
        {
            Assert.AreEqual(1, Task1450.BusyStudent(new[] {1, 2, 3}, new[] {3, 2, 7}, 4));
            Assert.AreEqual(1, Task1450.BusyStudent(new[] {4}, new[] {4}, 4));
            Assert.AreEqual(0, Task1450.BusyStudent(new[] {4}, new[] {4}, 5));
            Assert.AreEqual(0, Task1450.BusyStudent(new[] {1, 1, 1, 1}, new[] {1, 3, 2, 4}, 7));
            Assert.AreEqual(5,
                Task1450.BusyStudent(new[] {9, 8, 7, 6, 5, 4, 3, 2, 1}, new[] {10, 10, 10, 10, 10, 10, 10, 10, 10}, 5));
        }
    }
}
