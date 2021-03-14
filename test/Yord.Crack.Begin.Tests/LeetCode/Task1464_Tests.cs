using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1464_Tests
    {
        [Test]
        public void Should_MaxProduct()
        {
            Assert.AreEqual(12, Task1464.MaxProduct(new []{3,4,5,2}));
            Assert.AreEqual(16, Task1464.MaxProduct(new []{1,5,4,5}));
            Assert.AreEqual(12, Task1464.MaxProduct(new []{3,7}));
        }
        
        [Test]
        public void Should_MaxProduct_N()
        {
            Assert.AreEqual(12, Task1464.MaxProduct_N(new []{3,4,5,2}));
            Assert.AreEqual(16, Task1464.MaxProduct_N(new []{1,5,4,5}));
            Assert.AreEqual(12, Task1464.MaxProduct_N(new []{3,7}));
        }
    }
}
