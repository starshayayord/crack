using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task3_Tests
    {
        [Test]
        public void Should_RemoveMiddleElement_Successfully()
        {
            var head = GenerateList(new[] {1, 2, 3, 4, 5, 6});
            var node = head;
            for (var i = 0; i < 3; i++)
            {
                node = node._next;
            }
            
            Task3.Node.RemoveMiddleElement(node);
            
            CollectionAssert.AreEqual(new[] {1, 2, 3, 5, 6}, head);
            
        }
        
        private Task3.Node GenerateList(int[] array)
        {
            var head = new Task3.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
