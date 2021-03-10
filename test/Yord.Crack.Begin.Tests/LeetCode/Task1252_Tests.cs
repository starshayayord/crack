using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1252_Tests
    {
        [Test]
        public void Should_FindOddCell()
        {
            Assert.AreEqual(6, Task1252.OddCells(2, 3, new[] { new [] {0,1},new [] {1,1}}));
            Assert.AreEqual(0, Task1252.OddCells(2, 2, new[] { new [] {1,1},new [] {0,0}}));
        }
    }
}
