using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class SimpleStack_Tests
    {

        [Test]
        public void Should_CheckIfEmpty_Successfully()
        {
            var stack = new SimpleStack<int>();
            
            Assert.IsTrue(stack.IsEmpty());
        }
        
        [Test]
        public void Should_PushAndPop_Successfully()
        {
            var stack = new SimpleStack<int>();
            
            stack.Push(1);
            stack.Push(2);
            
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Pop());
        }
        
        [Test]
        public void Should_Peek_Successfully()
        {
            var stack = new SimpleStack<int>();
            
            stack.Push(1);
            stack.Push(2);
            
            Assert.AreEqual(2, stack.Peek());
        }
    }
}
