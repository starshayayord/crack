using NUnit.Framework;
using Task1 = Yord.Crack.Begin.Chapter2.Task1;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    public class Task1_Tests
    {
        [Test]
        public void Should_RemoveDuplicates3UnsortedLinkedList()
        {
            var source = GenerateList(new[] {1, 1, 1, 2, 2, 1, 3, 1 ,3});
            var source2 = GenerateList(new[] {1});
            var source3 = GenerateList(new[] {1, 2});
            var source4 = GenerateList(new[] {1, 2, 3, 3, 3, 4, 1, 3, 3, 2});

            var cleaned1 = Task1.Node.RemoveUnsortedDuplicates3(source);
            var cleaned2 = Task1.Node.RemoveUnsortedDuplicates3(source2);
            var cleaned3 = Task1.Node.RemoveUnsortedDuplicates3(source3);
            var cleaned4 = Task1.Node.RemoveUnsortedDuplicates3(source4);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, cleaned1);
            CollectionAssert.AreEqual(new[] {1}, cleaned2);
            CollectionAssert.AreEqual(new[] {1, 2}, cleaned3);
            CollectionAssert.AreEqual(new[] {1, 2, 3, 4}, cleaned4);
        }
        
        [Test]
        public void Should_RemoveDuplicates2UnsortedLinkedList()
        {
            var source = GenerateList(new[] {1, 1, 1, 2, 2, 1, 3, 1 ,3});
            var source2 = GenerateList(new[] {1});
            var source3 = GenerateList(new[] {1, 2});
            var source4 = GenerateList(new[] {1, 2, 3, 3, 3, 4, 1, 3, 3, 2});

            var cleaned1 = Task1.Node.RemoveUnsortedDuplicates2(source);
            var cleaned2 = Task1.Node.RemoveUnsortedDuplicates2(source2);
            var cleaned3 = Task1.Node.RemoveUnsortedDuplicates2(source3);
            var cleaned4 = Task1.Node.RemoveUnsortedDuplicates2(source4);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, cleaned1);
            CollectionAssert.AreEqual(new[] {1}, cleaned2);
            CollectionAssert.AreEqual(new[] {1, 2}, cleaned3);
            CollectionAssert.AreEqual(new[] {1, 2, 3, 4}, cleaned4);
        }
        
        [Test]
        public void Should_RemoveDuplicates_UnsortedLinkedList()
        {
            var source = GenerateList(new[] {1, 1, 1, 2, 2, 1, 3, 1 ,3});
            var source2 = GenerateList(new[] {1});
            var source3 = GenerateList(new[] {1, 2});
            var source4 = GenerateList(new[] {1, 2, 3, 3, 3, 4, 1, 3, 3, 2});

            var cleaned1 = Task1.Node.RemoveUnsortedDuplicates(source);
            var cleaned2 = Task1.Node.RemoveUnsortedDuplicates(source2);
            var cleaned3 = Task1.Node.RemoveUnsortedDuplicates(source3);
            var cleaned4 = Task1.Node.RemoveUnsortedDuplicates(source4);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, cleaned1);
            CollectionAssert.AreEqual(new[] {1}, cleaned2);
            CollectionAssert.AreEqual(new[] {1, 2}, cleaned3);
            CollectionAssert.AreEqual(new[] {1, 2, 3, 4}, cleaned4);
        }
        
        [Test]
        public void Should_RemoveDuplicates_SortedLinkedList()
        {
            var source = GenerateList(new[] {1, 1, 1, 2, 2, 3, 3});
            var source2 = GenerateList(new[] {1});
            var source3 = GenerateList(new[] {1, 2});
            var source4 = GenerateList(new[] {1, 2, 3, 3, 3, 4});

            var cleaned1 = Task1.Node.RemoveSortedDuplicates(source);
            var cleaned2 = Task1.Node.RemoveSortedDuplicates(source2);
            var cleaned3 = Task1.Node.RemoveSortedDuplicates(source3);
            var cleaned4 = Task1.Node.RemoveSortedDuplicates(source4);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, cleaned1);
            CollectionAssert.AreEqual(new[] {1}, cleaned2);
            CollectionAssert.AreEqual(new[] {1, 2}, cleaned3);
            CollectionAssert.AreEqual(new[] {1, 2, 3, 4}, cleaned4);
        }

        private Task1.Node GenerateList(int[] array)
        {
            var head = new Task1.Node(array[0]);
            foreach (var v in array)
            {
                head.Append(v);
            }

            return head;
        }
    }
}
