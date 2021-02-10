using NUnit.Framework;
using Yord.Crack.Begin.Chapter7;

namespace Yord.Crack.Begin.Tests.Chapter7
{
    [TestFixture]
    public class Task12_Tests
    {
        [Test]
        public void Should_WorkAsHash()
        {
            var key = 12;
            var map = new Task12.MyHash<int, string>(4);
            
            Assert.AreEqual(0, map.Size);
            Assert.AreEqual(null, map.GetValueOrDefault(key));
            
            map.AddOrUpdate(key, "test");
            
            Assert.AreEqual(1, map.Size);
            Assert.AreEqual("test", map.GetValueOrDefault(key));
            
            map.AddOrUpdate(key, "test2");
            
            Assert.AreEqual(1, map.Size);
            Assert.AreEqual("test2", map.GetValueOrDefault(key));

            var key2 = 11;
            map.AddOrUpdate(key2, "test11");
            
            Assert.AreEqual(2, map.Size);
            Assert.AreEqual("test2", map.GetValueOrDefault(key));
            Assert.AreEqual("test11", map.GetValueOrDefault(key2));

            Assert.IsTrue(map.Remove(key2));
            Assert.AreEqual(1, map.Size);
            Assert.AreEqual("test2", map.GetValueOrDefault(key));
            Assert.AreEqual(null, map.GetValueOrDefault(key2));
            
            Assert.IsFalse(map.Remove(key2));
            Assert.AreEqual(1, map.Size);
            Assert.AreEqual("test2", map.GetValueOrDefault(key));
            Assert.AreEqual(null, map.GetValueOrDefault(key2));
            
            
        }
        
        
    }
}
