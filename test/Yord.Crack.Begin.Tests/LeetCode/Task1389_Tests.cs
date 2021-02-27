using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1389_Tests
    {
        [Test]
        public void Should_CreateTargetArray()
        {
            CollectionAssert.AreEqual(new[] {0, 4, 1, 3, 2},
                Task1389.CreateTargetArray(new[] {0, 1, 2, 3, 4}, new[] {0, 1, 2, 2, 1}));

            CollectionAssert.AreEqual(new[] {0, 1, 2, 3, 4},
                Task1389.CreateTargetArray(new[] {1, 2, 3, 4, 0}, new[] {0, 1, 2, 3, 0}));

            CollectionAssert.AreEqual(new[] {1}, Task1389.CreateTargetArray(new[] {1}, new[] {0}));
        }
        
        [Test]
        public void Should_CreateTargetArray_SmallerSelf()
        {
            CollectionAssert.AreEqual(new[] {0, 4, 1, 3, 2},
                Task1389.CreateTargetArray_SmallerSelf(new[] {0, 1, 2, 3, 4}, new[] {0, 1, 2, 2, 1}));

            CollectionAssert.AreEqual(new[] {0, 1, 2, 3, 4},
                Task1389.CreateTargetArray_SmallerSelf(new[] {1, 2, 3, 4, 0}, new[] {0, 1, 2, 3, 0}));

            CollectionAssert.AreEqual(new[] {1}, Task1389.CreateTargetArray_SmallerSelf(new[] {1}, new[] {0}));
        }
    }
}
