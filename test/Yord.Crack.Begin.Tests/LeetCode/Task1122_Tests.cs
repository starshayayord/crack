using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1122_Tests
    {
        [Test]
        public void Should_SortArrays()
        {
            CollectionAssert.AreEqual(new[] {2,2,2,1,4,3,3,9,6,7,19}, 
                Task1122.RelativeSortArray(
                    new []{2,3,1,3,2,4,6,7,9,2,19},
                    new []{2,1,4,3,9,6}));
        }
    }
}
