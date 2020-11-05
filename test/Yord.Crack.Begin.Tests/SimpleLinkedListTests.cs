using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class SimpleLinkedListTests
    {
        [Test]
        public void Should_AddFront_EmptyList()
        {
            var list = new SimpleLinkedList<int>();
            
            list.AddFront(1);
            
            Assert.AreEqual(1, list.Count);
        }
        
        [Test]
        public void Should_AddFront_NotEmptyList()
        {
            var list = new SimpleLinkedList<int>();
            list.AddFront(1);
            
            list.AddFront(2);
            
            Assert.AreEqual(2, list.Count);
        }
        
        
        [Test]
        public void Should_AddAfter_EmptyList()
        {
            var list = new SimpleLinkedList<int>();

            var result = list.AddAfterKey(1, 2);
            
            Assert.IsFalse(result);
        }
        
        [Test]
        public void Should_AddAfter_Successfully()
        {
            var list = new SimpleLinkedList<int>();
            list.AddFront(1);

            var result = list.AddAfterKey(1, 2);
            
            Assert.IsTrue(result);
        }
        
        [Test]
        public void Should_Remove_EmptyList()
        {
            var list = new SimpleLinkedList<int>();

            var result = list.Remove(1);
            
            Assert.IsFalse(result);
        }
        
        
        [Test]
        public void Should_Remove_Successfully()
        {
            var list = new SimpleLinkedList<int>();
            list.AddFront(1);
            list.AddFront(2);
            list.AddFront(3);

            var result = list.Remove(2);
            
            Assert.AreEqual(2, list.Count);
            Assert.IsTrue(result);
        }
        
        
        [Test]
        public void Should_AddLast_EmptyList()
        {
            var list = new SimpleLinkedList<int>();
            
            list.AddLast(1);
            
            Assert.AreEqual(1, list.Count);
        }
        
        [Test]
        public void Should_AddLast_NotEmptyList()
        {
            var list = new SimpleLinkedList<int>();
            list.AddLast(1);
            
            list.AddLast(2);
            
            Assert.AreEqual(2, list.Count);
        }
    }
}
