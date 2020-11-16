using NUnit.Framework;
using Yord.Crack.Begin.Chapter2;

namespace Yord.Crack.Begin.Tests.Chapter2
{
    [TestFixture]
    public class Task5_Tests
    {
        [Test]
        public void Should_CalculateDirectSum_WhenLastAddMore()
        {
            var first = GenerateList(new[] {9});
            var second = GenerateList(new[] {1});

            var sum = Task5.Node.DirectSum(first, second);

            CollectionAssert.AreEqual(new[] {1, 0}, sum);
        }

        [Test]
        public void Should_CalculateDirectSum_WhenLastAddMoreThan9()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {1, 6, 9});

            var sum = Task5.Node.DirectSum(first, second);

            CollectionAssert.AreEqual(new[] {1,0,7,8}, sum);
        }

        [Test]
        public void Should_CalculateDirectSum_WhenLong()
        {
            var first = GenerateList(new[] {9, 0, 9, 1, 4});
            var second = GenerateList(new[] {5, 9, 9});

            var sum = Task5.Node.DirectSum(first, second);

            CollectionAssert.AreEqual(new[] {9, 1, 5, 1, 3}, sum);
        }

        [Test]
        public void Should_CalculateDirectSum_WhenOneNode()
        {
            var first = GenerateList(new[] {1, 0, 9});

            var sum = Task5.Node.DirectSum(first, null);

            CollectionAssert.AreEqual(new[] {1, 0, 9}, sum);
        }

        [Test]
        public void Should_CalculateDirectSum_WhenDiffLength()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {5});

            var sum = Task5.Node.DirectSum(first, second);

            CollectionAssert.AreEqual(new[] {9, 1, 4}, sum);
        }

        [Test]
        public void Should_CalculateDirectSum_Successfully()
        {
            var first = GenerateList(new[] {7, 1, 6});
            var second = GenerateList(new[] {5, 9, 2});

            var sum = Task5.Node.DirectSum(first, second);

            CollectionAssert.AreEqual(new[] {1, 3, 0, 8}, sum);
        }

        [Test]
        public void Should_CalculateReverseSum3_WhenLastAddMore()
        {
            var first = GenerateList(new[] {9});
            var second = GenerateList(new[] {1});

            var reverseSum = Task5.Node.ReverseSum3(first, second);

            CollectionAssert.AreEqual(new[] {0, 1}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum3_WhenLastAddMoreThan9()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {1, 6, 9});

            var reverseSum = Task5.Node.ReverseSum3(first, second);

            CollectionAssert.AreEqual(new[] {0, 7, 8, 1}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum3_WhenLong()
        {
            var first = GenerateList(new[] {9, 0, 9, 1, 4});
            var second = GenerateList(new[] {5, 9, 9});

            var reverseSum = Task5.Node.ReverseSum3(first, second);

            CollectionAssert.AreEqual(new[] {4, 0, 9, 2, 4}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum3_WhenOneNode()
        {
            var first = GenerateList(new[] {1, 0, 9});

            var reverseSum = Task5.Node.ReverseSum3(first, null);

            CollectionAssert.AreEqual(new[] {1, 0, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum3_WhenDiffLength()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {5});

            var reverseSum = Task5.Node.ReverseSum3(first, second);

            CollectionAssert.AreEqual(new[] {4, 1, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum3_Successfully()
        {
            var first = GenerateList(new[] {7, 1, 6});
            var second = GenerateList(new[] {5, 9, 2});

            var reverseSum = Task5.Node.ReverseSum3(first, second);

            CollectionAssert.AreEqual(new[] {2, 1, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_WhenLastAddMore()
        {
            var first = GenerateList(new[] {9});
            var second = GenerateList(new[] {1});

            var reverseSum = Task5.Node.ReverseSum2(first, second);

            CollectionAssert.AreEqual(new[] {0, 1}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_WhenLastAddMoreThan9()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {1, 6, 9});

            var reverseSum = Task5.Node.ReverseSum2(first, second);

            CollectionAssert.AreEqual(new[] {0, 7, 8, 1}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_WhenLong()
        {
            var first = GenerateList(new[] {9, 0, 9, 1, 4});
            var second = GenerateList(new[] {5, 9, 9});

            var reverseSum = Task5.Node.ReverseSum2(first, second);

            CollectionAssert.AreEqual(new[] {4, 0, 9, 2, 4}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_WhenOneNode()
        {
            var first = GenerateList(new[] {1, 0, 9});

            var reverseSum = Task5.Node.ReverseSum2(first, null);

            CollectionAssert.AreEqual(new[] {1, 0, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_WhenDiffLength()
        {
            var first = GenerateList(new[] {9, 0, 9});
            var second = GenerateList(new[] {5});

            var reverseSum = Task5.Node.ReverseSum2(first, second);

            CollectionAssert.AreEqual(new[] {4, 1, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum2_Successfully()
        {
            var first = GenerateList(new[] {7, 1, 6});
            var second = GenerateList(new[] {5, 9, 2});

            var reverseSum = Task5.Node.ReverseSum2(first, second);

            CollectionAssert.AreEqual(new[] {2, 1, 9}, reverseSum);
        }

        [Test]
        public void Should_CalculateReverseSum_Successfully()
        {
            var first = GenerateList(new[] {7, 1, 6});
            var second = GenerateList(new[] {5, 9, 2});

            var reverseSum = Task5.Node.ReverseSum(first, second);

            CollectionAssert.AreEqual(new[] {2, 1, 9}, reverseSum);
        }

        private Task5.Node GenerateList(int[] array)
        {
            var head = new Task5.Node(array[0]);
            for (var i = 1; i < array.Length; i++)
            {
                head.Append(array[i]);
            }

            return head;
        }
    }
}
