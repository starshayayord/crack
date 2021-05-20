using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1217_Tests
    {
        [Test]
        public void Should_MinCostToMoveChips()
        {
            Assert.AreEqual(1, Task1217.MinCostToMoveChips(new[] {1, 2, 3}));
            Assert.AreEqual(2, Task1217.MinCostToMoveChips(new[] {2, 2, 2, 3, 3}));
            Assert.AreEqual(1, Task1217.MinCostToMoveChips(new[] {1, 1000000000}));
        }
    }
}
