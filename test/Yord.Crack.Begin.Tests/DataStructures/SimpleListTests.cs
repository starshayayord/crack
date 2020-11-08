using NUnit.Framework;
using Yord.Crack.Begin.DataStructures;

namespace Yord.Crack.Begin.Tests.DataStructures
{
    [TestFixture]
    public class SimpleListTests
    {
        [Test]
        public void Should_Count_Successfully()
        {
            var list = new SimpleList<int>(0);
            Assert.AreEqual(0, list.Count);

            list.Add(10);
            Assert.AreEqual(1, list.Count);

            var result = list.Remove(10);
            Assert.AreEqual(0, list.Count);
            Assert.IsTrue(result);
        }

        [Test]
        public void Should_Add_Successfully()
        {
            var list = new SimpleList<int>(0);

            list.Add(10);

            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(10, list[0]);
        }

        [Test]
        public void Should_Remove_Successfully()
        {
            var list = new SimpleList<int>(0);
            list.Add(10);
            list.Remove(10);

            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void Should_CopyTo_Successfully()
        {
            var list = new SimpleList<int>(0);
            list.Add(10);
            var array = new int [1];
            list.CopyTo(array, 0);

            CollectionAssert.AreEquivalent(list, array);
        }

        [Test]
        public void Should_SetByIndex_Successfully()
        {
            var list = new SimpleList<int>(1);
            list[0] = 10;

            Assert.AreEqual(10, list[0]);
        }

        [Test]
        public void Should_Clear_Successfully()
        {
            var list = new SimpleList<int>(1);
            list[0] = 10;
            list.Clear();

            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void Should_GetRange_Successfully()
        {
            var list = new SimpleList<int>(2);
            list[0] = 10;
            list[1] = 2;
            var range = list.GetRange(0, 1);

            CollectionAssert.AreEquivalent(new[] {10}, range);
        }

        [Test]
        public void Should_Contains_Successfully()
        {
            var list = new SimpleList<int>(1);
            list[0] = 10;
            var contains1 = list.Contains(10);
            var contains2 = list.Contains(11);

            Assert.IsTrue(contains1);
            Assert.IsFalse(contains2);
        }
        
        [Test]
        public void Should_RemoveRange_Successfully()
        {
            var list = new SimpleList<int>(2);
            list[0] = 10;
            list[1] = 10;
            list.RemoveRange(0,2);

            Assert.AreEqual(0, list.Count);
        }
    }
}
