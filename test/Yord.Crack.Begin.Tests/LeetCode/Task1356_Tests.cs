using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1356_Tests
    {
        [Test]
        public void Should_SortByBits()
        {
            CollectionAssert.AreEqual(new[] {0, 1, 2, 4, 8, 3, 5, 6, 7},
                Task1356.SortByBits(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8}));
            CollectionAssert.AreEqual(new[] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024},
                Task1356.SortByBits(new[] {1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1}));
            CollectionAssert.AreEqual(new[] {10000, 10000}, Task1356.SortByBits(new[] {10000, 10000}));
            CollectionAssert.AreEqual(new[] {2, 3, 5, 17, 7, 11, 13, 19},
                Task1356.SortByBits(new[] {2, 3, 5, 7, 11, 13, 17, 19}));
            CollectionAssert.AreEqual(new[] {10, 100, 10000, 1000}, Task1356.SortByBits(new[] {10, 100, 1000, 10000}));
        }
        
        [Test]
        public void Should_SortByBits2()
        {
            CollectionAssert.AreEqual(new[] {0, 1, 2, 4, 8, 3, 5, 6, 7},
                Task1356.SortByBits2(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8}));
            CollectionAssert.AreEqual(new[] {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024},
                Task1356.SortByBits2(new[] {1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1}));
            CollectionAssert.AreEqual(new[] {10000, 10000}, Task1356.SortByBits2(new[] {10000, 10000}));
            CollectionAssert.AreEqual(new[] {2, 3, 5, 17, 7, 11, 13, 19},
                Task1356.SortByBits2(new[] {2, 3, 5, 7, 11, 13, 17, 19}));
            CollectionAssert.AreEqual(new[] {10, 100, 10000, 1000}, Task1356.SortByBits2(new[] {10, 100, 1000, 10000}));
        }
    }
}
