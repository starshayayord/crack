using NUnit.Framework;
using Yord.Crack.Begin.Chapter3;

namespace Yord.Crack.Begin.Tests.Chapter3
{
    [TestFixture]
    public class SimpleQueue_Tests
    {
        [Test]
        public void Should_CheckIfEmpty_Successfully()
        {
            var queue = new SimpleQueue<int>();

            Assert.IsTrue(queue.IsEmpty());
        }

        [Test]
        public void Should_EnqueueAndDequeue_Successfully()
        {
            var queue = new SimpleQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);

            Assert.AreEqual(1, queue.Dequeue());
            Assert.AreEqual(2, queue.Dequeue());
        }

        [Test]
        public void Should_Peek_Successfully()
        {
            var stack = new SimpleQueue<int>();

            stack.Enqueue(1);
            stack.Enqueue(2);

            Assert.AreEqual(1, stack.Peek());
        }
    }
}
