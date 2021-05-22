using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task922_Tests
    {
        [Test]
        public void Should_SortArrayByParityII()
        {
            CollectionAssert.AreEqual(new[] {2, 3}, Task922.SortArrayByParityII(new[] {2, 3}));
            CollectionAssert.AreEqual(new[] {4, 3}, Task922.SortArrayByParityII(new[] {3, 4}));
            CollectionAssert.AreEqual(new[] {4, 5, 2, 7}, Task922.SortArrayByParityII(new[] {4, 2, 5, 7}));
        }
        
        [Test]
        public void Should_SortArrayByParityII2()
        {
            CollectionAssert.AreEqual(new[] {2, 3}, Task922.SortArrayByParityII2(new[] {2, 3}));
            CollectionAssert.AreEqual(new[] {4, 3}, Task922.SortArrayByParityII2(new[] {3, 4}));
            CollectionAssert.AreEqual(new[] {4, 5, 2, 7}, Task922.SortArrayByParityII2(new[] {4, 2, 5, 7}));
        }
    }
}
