using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task8_Tests
    {
        [Test]
        public void Should_GetLoopNode_WhenNone()
        {
            var list = GenerateList(new[] {1, 2, 3, 4, 5});

            var loop = Task8.Node.GetLoopNode(list);

            Assert.AreEqual(null, loop);
        }

        [Test]
        public void Should_GetLoopNode_WhenMiddle()
        {
            var list = GetList();

            var loop = Task8.Node.GetLoopNode(list);

            Assert.AreEqual(list._next, loop);
        }

        private Task8.Node GetList()
        {
            var head = new Task8.Node(1);
            head._next = new Task8.Node(2);
            var n = head._next;
            foreach (var i in new[] {3, 2, 5})
            {
                n.Append(i);
                n = n._next;
            }

            n._next = head._next;
            return head;
        }

        private Task8.Node GenerateList(int[] array)
        {
            var head = new Task8.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
