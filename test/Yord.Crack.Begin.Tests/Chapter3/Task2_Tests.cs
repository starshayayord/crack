using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task2_Tests
    {
        [Test]
        public void Should_PushPopMin_WhenStack()
        {
            var stack = new Task2.StackWithMin<int>();
            
            stack.Push(5);
            stack.Push(4);
            
            Assert.AreEqual(4, stack.Min());
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(5, stack.Min());
        }
        
        [Test]
        public void Should_PushPopMin_WhenStack2()
        {
            var stack = new Task2.StackWithMin2<int>();
            
            stack.Push(5);
            stack.Push(4);
            
            Assert.AreEqual(4, stack.Min());
            Assert.AreEqual(4, stack.Pop());
            Assert.AreEqual(5, stack.Min());
        }
    }
}
