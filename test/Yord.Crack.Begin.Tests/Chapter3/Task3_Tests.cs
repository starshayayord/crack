using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task3_Tests
    {
        [Test]
        public void Should_PopAndPush_Successfully()
        {
            var set = new Task3.SetOfStacks<int>(2);
            foreach (var i in new []{1,2,  3,4,  5,6,  7,8,  9})
            {
                set.Push(i);
            }
            
            Assert.AreEqual(5, set.NumberOfStacks);
            Assert.AreEqual(9, set.Pop());
            Assert.AreEqual(4, set.NumberOfStacks);
            Assert.AreEqual(8, set.Pop());
            Assert.AreEqual(4, set.NumberOfStacks);
            Assert.AreEqual(7, set.PeekAt(3));
            Assert.AreEqual(4, set.PopAt(1));
            Assert.AreEqual(3, set.NumberOfStacks);
            Assert.AreEqual(2, set.PeekAt(0));
            Assert.AreEqual(5, set.PeekAt(1));
            Assert.AreEqual(7, set.PeekAt(2));
        }
        
        [Test]
        public void Should_PopAndPush2_Successfully()
        {
            var set = new Task3.SetOfStacks2<int>(2);
            foreach (var i in new []{1,2,  3,4,  5,6,  7,8,  9})
            {
                set.Push(i);
            }
            
            Assert.AreEqual(5, set.NumberOfStacks);
            Assert.AreEqual(9, set.Pop());
            Assert.AreEqual(4, set.NumberOfStacks);
            Assert.AreEqual(8, set.Pop());
            Assert.AreEqual(4, set.NumberOfStacks);
            Assert.AreEqual(7, set.PeekAt(3));
            Assert.AreEqual(4, set.PopAt(1));
            Assert.AreEqual(3, set.NumberOfStacks);
            Assert.AreEqual(2, set.PeekAt(0));
            Assert.AreEqual(5, set.PeekAt(1));
            Assert.AreEqual(7, set.PeekAt(2));
        }
    }
}
