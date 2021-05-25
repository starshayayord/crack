using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task821_Tests
    {
        [Test]
        public void Should_ShortestToChar()
        {
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0},
                Task821.ShortestToChar("loveleetcode", 'e'));
            
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0, 1,2},
                Task821.ShortestToChar("loveleetcodell", 'e'));
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0}, Task821.ShortestToChar("aaab", 'b'));
        }
        
        [Test]
        public void Should_ShortestToChar2()
        {
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0},
                Task821.ShortestToChar2("loveleetcode", 'e'));
            
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0, 1,2},
                Task821.ShortestToChar2("loveleetcodell", 'e'));
            CollectionAssert.AreEqual(new[] {3, 2, 1, 0}, Task821.ShortestToChar("aaab", 'b'));
        }
    }
}
