using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1748_Tests
    {
        [Test]
        public void Should_SumUnique()
        {
            Assert.AreEqual(4, Task1748.SumOfUnique(new [] {1,2,3,2}));
            Assert.AreEqual(0, Task1748.SumOfUnique(new [] {1,1,1,1,1}));
            Assert.AreEqual(15, Task1748.SumOfUnique(new [] {1,2,3,4,5}));
        }
        
        [Test]
        public void Should_SumUnique_Arr()
        {
            Assert.AreEqual(4, Task1748.SumOfUnique_Arr(new [] {1,2,3,2}));
            Assert.AreEqual(0, Task1748.SumOfUnique_Arr(new [] {1,1,1,1,1}));
            Assert.AreEqual(15, Task1748.SumOfUnique_Arr(new [] {1,2,3,4,5}));
        }
    }
}
