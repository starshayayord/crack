using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task242_Tests
    {
        [Test]
        public void Should_IsAnagram()
        {
            Assert.IsTrue(Task242.IsAnagram("anagram", "nagaram"));
            Assert.IsFalse(Task242.IsAnagram("rat", "car"));
        }
        
        [Test]
        public void Should_IsAnagram_Diff()
        {
            Assert.IsTrue(Task242.IsAnagram_DiffChars("anagram", "nagaram"));
            Assert.IsFalse(Task242.IsAnagram_DiffChars("rat", "car"));
        }
    }
}
