using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1827_Tests
    {
        [Test]
        public void Should_()
        {
            Assert.AreEqual(14, Task1827.MinOperations(new[] {1, 5, 2, 4, 1}));
            Assert.AreEqual(3, Task1827.MinOperations(new[] {1, 1, 1}));
            Assert.AreEqual(0, Task1827.MinOperations(new[] {8}));
        }
    }
}
