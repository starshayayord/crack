using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_InsertMIntoN_Successfully()
        {
            Assert.AreEqual(1100, Task1.Insert(1024, 19,2,6));
        }
        
        [Test]
        public void Should_InsertMIntoN1_Successfully()
        {
            Assert.AreEqual(1100, Task1.Insert1(1024, 19,2,6));
        }
        
        [Test]
        public void Should_InsertMIntoN2_Successfully()
        {
            Assert.AreEqual(1100, Task1.Insert2(1024, 19,2,6));
        }
    }
}
