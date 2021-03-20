using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1475_Tests
    {
        [Test]
        public void _Should_GetFinalPrices()
        {
            CollectionAssert.AreEqual(new [] {4,2,4,2,3}, Task1475.FinalPrices(new []{8,4,6,2,3}));
            CollectionAssert.AreEqual(new [] {1,2,3,4,5}, Task1475.FinalPrices(new []{1,2,3,4,5}));
            CollectionAssert.AreEqual(new [] {9,0,1,6}, Task1475.FinalPrices(new []{10,1,1,6}));
            CollectionAssert.AreEqual(new [] {1,3,2,1,7,0,0,6,9,1}, Task1475.FinalPrices(new []{8,7,4,2,8,1,7,7,10,1}));
        }
    }
}
