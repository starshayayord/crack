using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task4_Tests
    {
        [Test]
        public void Should_SplitList2_Successfully()
        {
            var sourceList = GenerateList(new[] {3, 5, 8, 5, 10, 2, 1});

            var split = Task4.Node.SplitList2(sourceList, 5);

            CollectionAssert.AreEqual(new[] {1, 2, 3, 10, 5, 8, 5}, split);
        }

        [Test]
        public void Should_SplitList_Successfully()
        {
            var sourceList = GenerateList(new[] {3, 5, 8, 5, 10, 2, 1});

            var split = Task4.Node.SplitList(sourceList, 5);

            CollectionAssert.AreEqual(new[] {3, 2, 1, 5, 10, 5, 8}, split);
        }

        private Task4.Node GenerateList(int[] array)
        {
            var head = new Task4.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
