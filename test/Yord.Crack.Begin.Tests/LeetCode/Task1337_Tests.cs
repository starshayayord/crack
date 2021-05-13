using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1337_Tests
    {
        [Test]
        public void Should_KWeakestRows()
        {
            CollectionAssert.AreEqual(new[] {2, 0, 3}, Task1337.KWeakestRows(new[]
            {
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 0},
                new[] {1, 0, 0, 0, 0},
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 1}
            }, 3));

            CollectionAssert.AreEqual(new[] {0, 2}, Task1337.KWeakestRows(new[]
            {
                new[] {1, 0, 0, 0},
                new[] {1, 1, 1, 1},
                new[] {1, 0, 0, 0},
                new[] {1, 0, 0, 0}
            }, 2));
        }

        [Test]
        public void Should_KWeakestRows2()
        {
            CollectionAssert.AreEqual(new[] {1, 2, 3}, Task1337.KWeakestRows2(new[]
            {
                new[] {1, 1, 1, 1, 1},
                new[] {1, 0, 0, 0, 0},
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 0},
                new[] {1, 1, 1, 1, 1},
            }, 3));
            CollectionAssert.AreEqual(new[] {2, 0, 3}, Task1337.KWeakestRows2(new[]
            {
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 0},
                new[] {1, 0, 0, 0, 0},
                new[] {1, 1, 0, 0, 0},
                new[] {1, 1, 1, 1, 1}
            }, 3));

            CollectionAssert.AreEqual(new[] {0, 2}, Task1337.KWeakestRows2(new[]
            {
                new[] {1, 0, 0, 0},
                new[] {1, 1, 1, 1},
                new[] {1, 0, 0, 0},
                new[] {1, 0, 0, 0}
            }, 2));
        }
    }
}
