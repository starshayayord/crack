using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task6_Tests
    {
        [Test]
        public void Should_MoveDisks_1Disks()
        {
            var resultTower = Task6.MoveDisks(1);

            CollectionAssert.AreEqual(new[] {1}, resultTower._tower);
        }
        
        [Test]
        public void Should_MoveDisks_2Disks()
        {
            var resultTower = Task6.MoveDisks(2);

            CollectionAssert.AreEqual(new[] {1, 2}, resultTower._tower);
        }
        
        [Test]
        public void Should_MoveDisks_3Disks()
        {
            var resultTower = Task6.MoveDisks(3);

            CollectionAssert.AreEqual(new[] {1, 2, 3}, resultTower._tower);
        }
        
        [Test]
        public void Should_MoveDisks_4Disks()
        {
            var resultTower = Task6.MoveDisks(4);

            CollectionAssert.AreEqual(new[] {1, 2, 3, 4}, resultTower._tower);
        }
    }
}
