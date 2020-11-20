using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task1_Tests
    {
        [Test]
        public void Should_PushAndPop_AllLists()
        {
            var stacks = new Task1.ArrStack<int>(3, 3);
            stacks.Push(0, 1);
            stacks.Push(0, 10);
            stacks.Push(1, 2);
            stacks.Push(1, 20);
            stacks.Push(2, 3);
            stacks.Push(2, 30);
            
            Assert.IsFalse(stacks.IsEmpty(0));
            Assert.IsFalse(stacks.IsEmpty(1));
            Assert.IsFalse(stacks.IsEmpty(2));
            Assert.AreEqual(10, stacks.Peek(0));
            Assert.AreEqual(10, stacks.Pop(0));
            Assert.AreEqual(1, stacks.Pop(0));
            Assert.AreEqual(20, stacks.Peek(1));
            Assert.AreEqual(20, stacks.Pop(1));
            Assert.AreEqual(2, stacks.Pop(1));
            Assert.AreEqual(30, stacks.Peek(2));
            Assert.AreEqual(30, stacks.Pop(2));
            Assert.AreEqual(3, stacks.Pop(2));
            Assert.IsTrue(stacks.IsEmpty(0));
            Assert.IsTrue(stacks.IsEmpty(1));
            Assert.IsTrue(stacks.IsEmpty(2));
        }
        
        [Test]
        public void Should_PushAndPop2_AllLists()
        {
            var stacks = new Task1.ArrStack2<int>();
            stacks.Push(1, 0);
            stacks.Push(10, 0);
            stacks.Push(2, 1);
            stacks.Push(20, 1);
            stacks.Push(3, 2);
            stacks.Push(30, 2);
            
            Assert.IsFalse(stacks.IsEmpty(0));
            Assert.IsFalse(stacks.IsEmpty(1));
            Assert.IsFalse(stacks.IsEmpty(2));
            Assert.AreEqual(10, stacks.Peek(0));
            Assert.AreEqual(10, stacks.Pop(0));
            Assert.AreEqual(1, stacks.Pop(0));
            Assert.AreEqual(20, stacks.Peek(1));
            Assert.AreEqual(20, stacks.Pop(1));
            Assert.AreEqual(2, stacks.Pop(1));
            Assert.AreEqual(30, stacks.Peek(2));
            Assert.AreEqual(30, stacks.Pop(2));
            Assert.AreEqual(3, stacks.Pop(2));
            Assert.IsTrue(stacks.IsEmpty(0));
            Assert.IsTrue(stacks.IsEmpty(1));
            Assert.IsTrue(stacks.IsEmpty(2));
        }
        
        [Test]
        public void Should_PushAndPop1_AllLists()
        {
            var stacks = new Task1.ArrStack1<int>();
            stacks.Push(1, 1);
            stacks.Push(10, 1);
            stacks.Push(2, 2);
            stacks.Push(20, 2);
            stacks.Push(3, 3);
            stacks.Push(30, 3);
            
            Assert.AreEqual(10, stacks.Pop(1));
            Assert.AreEqual(1, stacks.Pop(1));
            Assert.AreEqual(20, stacks.Pop(2));
            Assert.AreEqual(2, stacks.Pop(2));
            Assert.AreEqual(30, stacks.Pop(3));
            Assert.AreEqual(3, stacks.Pop(3));
        }
    }
}
