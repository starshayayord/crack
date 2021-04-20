using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1638_Tests
    {
        [Test]
        public void Should_CountSubstrings()
        {
            Assert.AreEqual(6, Task1638.CountSubstrings("aba", "baba"));
            Assert.AreEqual(3, Task1638.CountSubstrings("ab", "bb"));
            Assert.AreEqual(0, Task1638.CountSubstrings("a", "a"));
            Assert.AreEqual(10, Task1638.CountSubstrings("abe", "bbc"));
        }
        
        [Test]
        public void Should_CountSubstrings2()
        {
            Assert.AreEqual(6, Task1638.CountSubstrings2("aba", "baba"));
            Assert.AreEqual(3, Task1638.CountSubstrings2("ab", "bb"));
            Assert.AreEqual(0, Task1638.CountSubstrings2("a", "a"));
            Assert.AreEqual(10, Task1638.CountSubstrings2("abe", "bbc"));
        }
        
        [Test]
        public void Should_CountSubstrings3()
        {
           
            Assert.AreEqual(3, Task1638.CountSubstrings3("ab", "bb"));
            Assert.AreEqual(0, Task1638.CountSubstrings3("a", "a"));
            Assert.AreEqual(10, Task1638.CountSubstrings3("abe", "bbc"));
            Assert.AreEqual(6, Task1638.CountSubstrings3("aba", "baba"));
        }
    }
}
