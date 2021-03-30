using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task705_Tests
    {
        [Test]
        public void Should_UseMyHashSet_Bit()
        {
            var t = new Task705.MyHashSet_Bit();
            t.Add(1);
            t.Add(2);
            Assert.IsTrue(t.Contains(1));
            Assert.IsFalse(t.Contains(3));
            t.Add(2);
            Assert.IsTrue(t.Contains(2));
            t.Remove(2);
            Assert.IsFalse(t.Contains(2));
            t.Add(1000000);
            Assert.IsTrue(t.Contains(1000000));
        }
        
        [Test]
        public void Should_UseMyHashSet_List()
        {
            var t = new Task705.MyHashSet();
            t.Add(1);
            t.Add(2);
            t.Add(5);
            t.Add(8);
            t.Add(10);
            Assert.IsTrue(t.Contains(1));
            Assert.IsFalse(t.Contains(3));
            t.Add(2);
            Assert.IsTrue(t.Contains(2));
            t.Remove(2);
            Assert.IsFalse(t.Contains(2));
            t.Add(1000000);
            Assert.IsTrue(t.Contains(1000000));
        }
    }
}
