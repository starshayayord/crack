using NUnit.Framework;
using Yord.Crack.Begin.DataStructures;

namespace Yord.Crack.Begin.Tests.DataStructures
{
    [TestFixture]
    public class SimpleDictionaryTests
    {
        [Test]
        public void Should_InsertElement_Successfully()
        {
            var dict = new SimpleDictionary<int, int>(8);

            dict.Insert(10, 1);

            Assert.AreEqual(1, dict.Count);
        }

        [Test]
        public void Should_RemoveElement_Successfully()
        {
            var dict = new SimpleDictionary<int, int>(8);
            dict.Insert(10, 1);

            var removeResult = dict.Remove(10);

            Assert.IsTrue(removeResult);
            Assert.AreEqual(0, dict.Count);
        }
        
        [Test]
        public void Should_GetValue_Successfully()
        {
            var dict = new SimpleDictionary<int, int>(8);
            dict.Insert(10, 1);

            var value = dict.GetValueOrDefault(10);

            Assert.AreEqual(1, value);
        }
        
        [Test]
        public void Should_GetValueOrDefault_Successfully()
        {
            var dict = new SimpleDictionary<int, int>(8);

            var value = dict.GetValueOrDefault(32);

            Assert.AreEqual(0, value);
        }
        
        [Test]
        public void Should_GetValue_WhenChanged()
        {
            var dict = new SimpleDictionary<int, int>(8);
            dict.Insert(10, 1);
            dict.Insert(10, 2);
            
            var value = dict.GetValueOrDefault(10);
            
            Assert.AreEqual(2, value);
        }
        
        
        [Test]
        public void Should_GetValueOrDefault_ByIndexer()
        {
            var dict = new SimpleDictionary<int, int>(1);
            dict.Insert(10, 1);
            
            var value = dict[10];

            Assert.AreEqual(1, value);
        }
        
        [Test]
        public void Should_SetValue_ByIndexer()
        {
            var dict = new SimpleDictionary<int, int>(1);
            
            dict[10] =  1;
            
            var value = dict[10];
            Assert.AreEqual(1, value);
        }
    }
}
