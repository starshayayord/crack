using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class Task4_Tests
    {
        [Test]
        public void Should_WorkAsQueue_Successfully()
        {
            var queue = new Task4.QueueStack<int>();
            
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            
            Assert.IsFalse(queue.IsEmpty());
            Assert.AreEqual(3, queue.Peek()); 
            Assert.AreEqual(3, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
            queue.Enqueue(4);
            Assert.AreEqual(1, queue.Peek());
            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(4, queue.Dequeue());
            Assert.IsTrue(queue.IsEmpty());
        }
    }
}
