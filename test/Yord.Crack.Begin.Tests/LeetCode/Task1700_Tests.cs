using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1700_Tests
    {
        [Test]
        public void Should_CountStudents()
        {
            Assert.AreEqual(0, Task1700.CountStudents(new[] {1, 1, 0, 0}, new[] {0, 1, 0, 1}));
            Assert.AreEqual(3, Task1700.CountStudents(new[] {1, 1, 1, 0, 0, 1}, new[] {1, 0, 0, 0, 1, 1}));
        }
    }
}
