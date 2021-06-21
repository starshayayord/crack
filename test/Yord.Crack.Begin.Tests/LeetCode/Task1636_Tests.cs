using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1636_Tests
    {
        [Test]
        public void Should_SortByFreq()
        {
            CollectionAssert.AreEqual(new[] {3, 1, 1, 2, 2, 2}, Task1636.FrequencySort(new[] {1, 1, 2, 2, 2, 3}));
            CollectionAssert.AreEqual(new[] {1, 3, 3, 2, 2}, Task1636.FrequencySort(new[] {2, 3, 1, 3, 2}));
            CollectionAssert.AreEqual(new[] {5, -1, 4, 4, -6, -6, 1, 1, 1},
                Task1636.FrequencySort(new[] {-1, 1, -6, 4, 5, -6, 1, 4, 1}));
        }
    }
}
