using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task2_Tests
    {
        [Test]
        public void Should_FindElementIter_Successfully()
        {
            var list = GenerateList(new[] {1, 2, 3});
            
            Assert.AreEqual(1, Task2.Node.FindKFromEnd3(list,3));
            Assert.AreEqual(2, Task2.Node.FindKFromEnd3(list,2));
            Assert.AreEqual(3, Task2.Node.FindKFromEnd3(list,1));
            Assert.AreEqual(-1, Task2.Node.FindKFromEnd3(list,4));
        }
        
        [Test]
        public void Should_FindElementRec_Successfully()
        {
            var list = GenerateList(new[] {1, 2, 3});
            
            Assert.AreEqual(1, Task2.Node.FindKFromEnd2(list,3));
            Assert.AreEqual(2, Task2.Node.FindKFromEnd2(list,2));
            Assert.AreEqual(3, Task2.Node.FindKFromEnd2(list,1));
            Assert.AreEqual(-1, Task2.Node.FindKFromEnd2(list,4));
        }
        
        [Test]
        public void Should_FindElement_Successfully()
        {
            var list = GenerateList(new[] {1, 2, 3});
            
            Assert.AreEqual(1, list.FindKFromEnd(3));
            Assert.AreEqual(2, list.FindKFromEnd(2));
            Assert.AreEqual(3, list.FindKFromEnd(1));
            Assert.AreEqual(-1, list.FindKFromEnd(4));
        }
        
        private Task2.Node GenerateList(int[] array)
        {
            var head = new Task2.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
