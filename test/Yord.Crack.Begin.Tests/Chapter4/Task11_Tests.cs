using System.Linq;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task11_Tests
    {
        [Test]
        public void Should_RemoveFromBst_Successfully()
        {
            var array = new[] {8, 4, 10, 2, 6, 20};
            var tree = GetTree(array);

            tree.Remove(4);

            Assert.AreEqual(array.Length - 1, tree.Size);
        }

        [Test]
        public void Should_InsertIntoBst_Successfully()
        {
            var tree = new Task11.BSTree();
            var array = new[] {8, 4, 10, 2, 6, 20};
            foreach (var i in array)
            {
                tree.Insert(i);
            }

            Assert.AreEqual(array.Length, tree.Size);
        }

        [Test]
        public void Should_SearchInBst_Successfully()
        {
            var tree = GetTree(new[] {8, 4, 10, 2, 6, 20});

            Assert.AreEqual(6, tree.Find(6).Value);
            Assert.IsNull(tree.Find(55));
        }

        [Test]
        public void Should_GetRandom_Successfully()
        {
            var source = new[] {1, 2};
            var tree = GetTree(source);

            var randomNodes = new int[100];
            for (var i = 0; i < 100; i++)
            {
                randomNodes[i] = tree.GetRandomNode().Value;
            }

            CollectionAssert.AreEquivalent(source, randomNodes.Distinct());
        }

        private Task11.BSTree GetTree(int[] array)
        {
            var tree = new Task11.BSTree();
            foreach (var i in array)
            {
                tree.Insert(i);
            }

            return tree;
        }
    }
}
