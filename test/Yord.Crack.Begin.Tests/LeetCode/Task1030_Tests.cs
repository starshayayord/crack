using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1030_Tests
    {
        [Test]
        public void Should_AllCellsDistOrder()
        {
            CollectionAssert.AreEqual(new[] {new[] {0, 0}, new[] {0, 1}}, Task1030.AllCellsDistOrder(1, 2, 0, 0));
            CollectionAssert.AreEqual(new[] {new[] {0, 1}, new[] {0, 0}, new[] {1, 1}, new[] {1, 0}},
                Task1030.AllCellsDistOrder(2, 2, 0, 1));
            CollectionAssert.AreEqual(
                new[] {new[] {1, 2}, new[] {0, 2}, new[] {1, 1}, new[] {0, 1}, new[] {1, 0}, new[] {0, 0}},
                Task1030.AllCellsDistOrder(2, 3, 1, 2));
        }
    }
}
