using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1491_Tests
    {
        [Test]
        public void Should_CalcSalary()
        {
            Assert.AreEqual(2500.0, Task1491.Average(new[] {4000, 3000, 1000, 2000}));
            Assert.AreEqual(2000.0, Task1491.Average(new[] {1000, 2000, 3000}));
            Assert.AreEqual(3500.0, Task1491.Average(new[] {6000, 5000, 4000, 3000, 2000, 1000}));
            Assert.AreEqual(4750.0, Task1491.Average(new[] {8000, 9000, 2000, 3000, 6000, 1000}));
        }
    }
}
