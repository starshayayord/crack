using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1295_Tests
    {
        [Test]
        public void Should_FindNumbers()
        {
            Assert.AreEqual(2, Task1295.FindNumbers(new[] {12,345,2,6,7896}));
            Assert.AreEqual(1, Task1295.FindNumbers(new[] {555,901,482,1771}));
        }
        
        [Test]
        public void Should_FindNumbers_Constraint()
        {
            Assert.AreEqual(2, Task1295.FindNumbers_Constraints(new[] {12,345,2,6,7896}));
            Assert.AreEqual(1, Task1295.FindNumbers_Constraints(new[] {555,901,482,1771}));
        }
        
        [Test]
        public void Should_FindNumbers_Log()
        {
            Assert.AreEqual(2, Task1295.FindNumbers_Log(new[] {12,345,2,6,7896}));
            Assert.AreEqual(1, Task1295.FindNumbers_Log(new[] {555,901,482,1771}));
        }
    }
}
