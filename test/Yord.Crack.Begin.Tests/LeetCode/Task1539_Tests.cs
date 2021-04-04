using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1539_Tests
    {
        [Test]
        public void Should_FindKthPositive()
        {
            Assert.AreEqual(6, Task1539.FindKthPositive(new []{1,2,3,4}, 2));
            Assert.AreEqual(2, Task1539.FindKthPositive(new []{3}, 2));
            Assert.AreEqual(2, Task1539.FindKthPositive(new []{1}, 1));
            Assert.AreEqual(2, Task1539.FindKthPositive(new []{3, 10}, 2));
            Assert.AreEqual(9, Task1539.FindKthPositive(new []{2,3,4,7,11}, 5));
            
        }
        
        [Test]
        public void Should_FindKthPositive2()
        {
            Assert.AreEqual(6, Task1539.FindKthPositive2(new []{1,2,3,4}, 2));
            Assert.AreEqual(2, Task1539.FindKthPositive2(new []{3}, 2));
            Assert.AreEqual(2, Task1539.FindKthPositive2(new []{1}, 1));
            Assert.AreEqual(2, Task1539.FindKthPositive2(new []{3, 10}, 2));
            Assert.AreEqual(9, Task1539.FindKthPositive2(new []{2,3,4,7,11}, 5));
            
        }
        
        [Test]
        public void Should_FindKthPositiveBs()
        {
            Assert.AreEqual(2, Task1539.FindKthPositiveBs(new []{3}, 2));
            Assert.AreEqual(2, Task1539.FindKthPositiveBs(new []{1}, 1));
            Assert.AreEqual(2, Task1539.FindKthPositiveBs(new []{3, 10}, 2));
            Assert.AreEqual(9, Task1539.FindKthPositiveBs(new []{2,3,4,7,11}, 5));
            Assert.AreEqual(6, Task1539.FindKthPositiveBs(new []{1,2,3,4}, 2));
        }
    }
}
