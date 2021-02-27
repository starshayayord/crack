using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1313_Tests
    {
        [Test]
        public void Should_DecompressRLElist()
        {
            CollectionAssert.AreEqual(new[] {2, 4, 4, 4}, Task1313.DecompressRLElist(new[] {1, 2, 3, 4}));
            CollectionAssert.AreEqual(new[] {1, 3, 3}, Task1313.DecompressRLElist(new[] {1, 1, 2, 3}));
        }
        
        [Test]
        public void Should_DecompressRLElist2()
        {
            CollectionAssert.AreEqual(new[] {2, 4, 4, 4}, Task1313.DecompressRLElist2(new[] {1, 2, 3, 4}));
            CollectionAssert.AreEqual(new[] {1, 3, 3}, Task1313.DecompressRLElist2(new[] {1, 1, 2, 3}));
        }
    }
}
