using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task893_Tests
    {
        [Test]
        public void Should_NumSpecialEquivGroups()
        {
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups(new[] {"abc", "acb", "bac", "bca", "cab", "cba"}));
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups(new[] {"abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"}));
        }
        
        [Test]
        public void Should_NumSpecialEquivGroups2()
        {
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups2(new[] {"abc", "acb", "bac", "bca", "cab", "cba"}));
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups2(new[] {"abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"}));
        }
        
        [Test]
        public void Should_NumSpecialEquivGroups3()
        {
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups3(new[] {"abc", "acb", "bac", "bca", "cab", "cba"}));
            Assert.AreEqual(3, Task893.NumSpecialEquivGroups3(new[] {"abcd", "cdab", "cbad", "xyzz", "zzxy", "zzyx"}));
        }
    }
}
