using System.Collections.Generic;
using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class DLinkedListTests
    {
        [Test]
        public void Should_AddFront_Successfully()
        {
            var dList = new DLinkedList<int>();

            dList.AddFront(1);
            dList.AddFront(2);

            CollectionAssert.AreEquivalent(new[] {2, 1}, dList);
        }

        [Test]
        public void Should_AddLast_Successfully()
        {
            var dList = new DLinkedList<int>();

            dList.AddLast(1);
            dList.AddLast(2);

            CollectionAssert.AreEquivalent(new[] {1, 2}, dList);
        }

        [Test]
        public void Should_AddAfterKey_Successfully()
        {
            var dList = new DLinkedList<int>();
            dList.AddLast(1);
            dList.AddLast(2);
            dList.AddLast(3);

            var addResult = dList.AddAfterKey(2, 4);

            Assert.IsTrue(addResult);
            CollectionAssert.AreEquivalent(new[] {1, 2, 4, 3}, dList);
        }

        [Test]
        public void Should_Remove_Successfully()
        {
            var dList = new DLinkedList<int>();
            dList.AddLast(1);
            dList.AddLast(2);
            dList.AddLast(3);
            dList.AddLast(4);

            var removeResult = dList.Remove(3);

            Assert.IsTrue(removeResult);
            CollectionAssert.AreEquivalent(new[] {1, 2, 4}, dList);
        }

        [Test]
        public void Should_Reverse_Successfully()
        {
            var dList = new DLinkedList<int>();
            var sourceList = new List<int> {1, 2, 3, 4};
            foreach (var l in sourceList)
            {
                dList.AddLast(l);
            }

            dList.Reverse();

            Assert.AreEqual(4, dList.Count);
            sourceList.Reverse();
            CollectionAssert.AreEquivalent(sourceList, dList);
        }
    }
}
