using NUnit.Framework;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class LinkedLists_Tests
    {
        [Test]
        public void Should_ReorganizeList_Successfully()
        {
            var initialList = CreateList(new[] {1, 2, 3, 4, 5, 6});
            var reorganized = LinkedLists.SingleNode.Reorganize(initialList);
        }

        private LinkedLists.SingleNode CreateList(int[] data)
        {
            var head = new LinkedLists.SingleNode(data[0]);
            var n = head;
            for (var i = 1; i < data.Length; i++)
            {
                n.AppendToTail(data[i]);
            }

            return head;
        }
    }
    
    
}
