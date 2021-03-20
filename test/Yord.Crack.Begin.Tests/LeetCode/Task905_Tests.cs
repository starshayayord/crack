using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task905_Tests
    {
        [Test]
        public void Should_SortArrayByParity()
        {
            CollectionAssert.AreEquivalent(new[] {2,4,3,1}, Task905.SortArrayByParity(new []{3,1,2,4}));
        }
    }
}
