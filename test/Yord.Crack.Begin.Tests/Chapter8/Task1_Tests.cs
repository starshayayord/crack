using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_CheckLadderVars()
        {
            Assert.AreEqual(1, Task1.CountWays2(1));
            Assert.AreEqual(2, Task1.CountWays2(2));
            Assert.AreEqual(4, Task1.CountWays2(3));
            Assert.AreEqual(7, Task1.CountWays2(4));
        }

        [Test]
        public void Should_CheckLadderVars_WithRecursion()
        {
            Assert.AreEqual(Task1.CountWaysRec(1), Task1.CountWays2(1));
            Assert.AreEqual(Task1.CountWaysRec(2), Task1.CountWays2(2));
            Assert.AreEqual(Task1.CountWaysRec(3), Task1.CountWays2(3));
            Assert.AreEqual(Task1.CountWaysRec(4), Task1.CountWays2(4));
            Assert.AreEqual(Task1.CountWaysRec(7), Task1.CountWays2(7));
        }
        
        [Test]
        public void Should_CheckLadderVars_Upwards()
        {
            Assert.AreEqual(Task1.CountWaysRec(1), Task1.CountWays3(1));
            Assert.AreEqual(Task1.CountWaysRec(2), Task1.CountWays3(2));
            Assert.AreEqual(Task1.CountWaysRec(3), Task1.CountWays3(3));
            Assert.AreEqual(Task1.CountWaysRec(4), Task1.CountWays3(4));
            Assert.AreEqual(Task1.CountWaysRec(7), Task1.CountWays3(7));
        }
    }
}
