using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task728_Tests
    {
        [Test]
        public void Should_GetSelfDividingNumbers()
        {
            CollectionAssert.AreEquivalent(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22},
                Task728.SelfDividingNumbers(1, 22));
        }
        
        [Test]
        public void Should_GetSelfDividingNumbers_Str()
        {
            CollectionAssert.AreEquivalent(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12, 15, 22},
                Task728.SelfDividingNumbers_Str(1, 22));
        }
    }
}
