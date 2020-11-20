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
            var stacks = new Task1.ArrStack<int>();
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
