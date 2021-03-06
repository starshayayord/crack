using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1534_Tests
    {
        [Test]
        public void Should_FindTriplets()
        {
            var triplets = Task1534.CountGoodTriplets(new[] {3, 0, 1, 1, 9, 7}, 7, 2, 3);
            Assert.AreEqual(4, triplets);
            
            triplets = Task1534.CountGoodTriplets(new[] {1, 1, 2, 2, 3}, 0, 0, 1);
            Assert.AreEqual(0, triplets);
        }
        
        [Test]
        public void Should_FindTriplets_FenwTree()
        {
            var triplets = Task1534.CountGoodTriplets_FenwTree(new[] {3, 0, 1, 1, 9, 7}, 7, 2, 3);
            Assert.AreEqual(4, triplets);
            
            triplets = Task1534.CountGoodTriplets_FenwTree(new[] {1, 1, 2, 2, 3}, 0, 0, 1);
            Assert.AreEqual(0, triplets);
        }
        
        [Test]
        public void Should_FindTriplets_Cache()
        {
            var triplets = Task1534.CountGoodTriplets_Cache(new[] {3, 0, 1, 1, 9, 7}, 7, 2, 3);
            Assert.AreEqual(4, triplets);
            
            triplets = Task1534.CountGoodTriplets_Cache(new[] {1, 1, 2, 2, 3}, 0, 0, 1);
            Assert.AreEqual(0, triplets);
        }
    }
}
