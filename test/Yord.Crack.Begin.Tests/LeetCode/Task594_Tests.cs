using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task594_Tests
    {
        [Test]
        public void Should_FindLHS()
        {
            Assert.AreEqual(20, Task594.FindLHS(new[] {2,2,2,2,2,2,2,3,1,0,0,0,3,1,-1,0,1,1,0,0,1,1,2,2,2,0,1,2,2,3,2}));
            Assert.AreEqual(5, Task594.FindLHS(new[] {1, 3, 2, 2, 5, 2, 3, 7}));
            Assert.AreEqual(2, Task594.FindLHS(new[] {1, 2, 3, 4}));
            Assert.AreEqual(0, Task594.FindLHS(new[] {1, 1, 1, 1}));
            Assert.AreEqual(4, Task594.FindLHS(new[] {-3,-1,-1,-1,-3,-2}));
        }
        
        [Test]
        public void Should_FindLHS_Window()
        {
            Assert.AreEqual(20, Task594.FindLHS_Window(new[] {2,2,2,2,2,2,2,3,1,0,0,0,3,1,-1,0,1,1,0,0,1,1,2,2,2,0,1,2,2,3,2}));
            Assert.AreEqual(5, Task594.FindLHS_Window(new[] {1, 3, 2, 2, 5, 2, 3, 7}));
            Assert.AreEqual(2, Task594.FindLHS_Window(new[] {1, 2, 3, 4}));
            Assert.AreEqual(0, Task594.FindLHS_Window(new[] {1, 1, 1, 1}));
            Assert.AreEqual(4, Task594.FindLHS_Window(new[] {-3,-1,-1,-1,-3,-2}));
        }
    }
}
