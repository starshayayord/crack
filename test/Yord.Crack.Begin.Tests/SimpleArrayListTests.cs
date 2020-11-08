using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class SimpleArrayListTests
    {
        [Test]
        public void Should_AddItem_Successfully()
        {
            var ar = new SimpleArrayList();
            
            ar.Add("test");
            
            Assert.AreEqual(1, ar.Count);
        }
        
        [Test]
        public void Should_RemoveItem_Successfully()
        {
            var ar = new SimpleArrayList(1);
            ar.Add("test");

            var removeResult = ar.Remove("test");
            
            Assert.IsTrue(removeResult);
            Assert.AreEqual(0, ar.Count);
        }
        
        [Test]
        public void ShouldNot_RemoveItem_WhenNotFound()
        {
            var ar = new SimpleArrayList(1);
            ar.Add("test");

            var removeResult = ar.Remove("test1");
            
            Assert.IsFalse(removeResult);
            Assert.AreEqual(1, ar.Count);
        }
        
        [Test]
        public void Should_InsertAt_Successfully()
        {
            var ar = new SimpleArrayList();
            ar.Add("test0");
            ar.Add("test1");

            ar.InsertAt(1, "replaced");
            
            Assert.AreEqual(3, ar.Count);
            CollectionAssert.AreEquivalent(new [] {"test0", "replaced", "test1"}, ar);
        }
    }
}
