using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task953_Tests
    {
        [Test]
        public void Should_IsAlienSorted()
        {
            Assert.IsFalse(Task953.IsAlienSorted(new[] {"apple", "app"}, "abcdefghijklmnopqrstuvwxyz"));
            Assert.IsTrue(Task953.IsAlienSorted(new[] {"hello", "leetcode"}, "hlabcdefgijkmnopqrstuvwxyz"));
            Assert.IsFalse(Task953.IsAlienSorted(new[] {"word", "world", "row"}, "worldabcefghijkmnpqstuvxyz"));
            
            Assert.IsTrue(Task953.IsAlienSorted(new[] {"hello", "hello"}, "abcdefghijklmnopqrstuvwxyz"));
            Assert.IsTrue(Task953.IsAlienSorted(new[] {"kuvp", "q"}, "ngxlkthsjuoqcpavbfdermiywz"));
        }
    }
}
