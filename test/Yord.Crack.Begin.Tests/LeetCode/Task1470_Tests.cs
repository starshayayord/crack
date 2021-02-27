using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1470_Tests
    {
        [Test]
        public void Should_ShuffleArray()
        {
            var arr = new[] {2, 5, 1, 3, 4, 7};
            
            CollectionAssert.AreEqual(new[] {2,3,5,4,1,7}, Task1470.Shuffle(arr, 3));
        }
        
        [Test]
        public void Should_ShuffleArray_NoSpace()
        {
            var arr = new[] {2, 5, 1, 3, 4, 7};
            
            CollectionAssert.AreEqual(new[] {2,3,5,4,1,7}, Task1470.Shuffle_NoSpace(arr, 3));
        }
       
    }
}
