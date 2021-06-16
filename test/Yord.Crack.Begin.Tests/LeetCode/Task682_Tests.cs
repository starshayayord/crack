using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task682_Tests
    {
        [Test]
        public void Should_CalcScore()
        {
            Assert.AreEqual(30, Task682.CalPoints(new []{"5","2","C","D","+"}));
            Assert.AreEqual(27, Task682.CalPoints(new []{"5","-2","4","C","D","9","+","+"}));
            Assert.AreEqual(1, Task682.CalPoints(new []{"1"}));
        }
        
        [Test]
        public void Should_CalcScore2()
        {
            Assert.AreEqual(30, Task682.CalPoints2(new []{"5","2","C","D","+"}));
            Assert.AreEqual(27, Task682.CalPoints2(new []{"5","-2","4","C","D","9","+","+"}));
            Assert.AreEqual(1, Task682.CalPoints2(new []{"1"}));
        }
    }
}
