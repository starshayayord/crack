using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1365_Tests
    {
        [Test]
        public void Should_SmallerNumbersThanCurrent()
        {
            var r = Task1365.SmallerNumbersThanCurrent(new[] {8, 1, 2, 2, 3});
            CollectionAssert.AreEqual(new[] {4,0,1,1,3}, r);
        }
        
        [Test]
        public void Should_SmallerNumbersThanCurrent_Dictionary()
        {
            var r = Task1365.SmallerNumbersThanCurrent_Dictionary(new[] {8, 1, 2, 2, 3});
            CollectionAssert.AreEqual(new[] {4,0,1,1,3}, r);
        }
    }
}
