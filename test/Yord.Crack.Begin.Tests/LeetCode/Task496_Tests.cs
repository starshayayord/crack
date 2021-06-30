using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task496_Tests
    {
        [Test]
        public void Should_NextGreaterElement()
        {
            CollectionAssert.AreEqual(new[] {-1, 3, -1},
                Task496.NextGreaterElement(new[] {4, 1, 2}, new[] {1, 3, 4, 2}));

            CollectionAssert.AreEqual(new[] {3, -1},
                Task496.NextGreaterElement(new[] {2, 4}, new[] {1, 2, 3, 4}));
        }
    }
}
