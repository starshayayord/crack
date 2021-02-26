using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1528_Tests
    {
        [Test]
        public void Should_RestoreString()
        {
            var str = "codeleet";
            var arr = new[] {4, 5, 6, 7, 0, 2, 1, 3};
            
            Assert.AreEqual("leetcode", Task1528.RestoreString(str, arr));
        }
        
        [Test]
        public void Should_RestoreString_Sort()
        {
            var str = "codeleet";
            var arr = new[] {4, 5, 6, 7, 0, 2, 1, 3};
            
            Assert.AreEqual("leetcode", Task1528.RestoreString_Sort(str, arr));
        }
    }
}
