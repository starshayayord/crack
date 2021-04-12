using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task720_Tests
    {
        [Test]
        public void Should_LongestWord()
        {
            Assert.AreEqual("apple", Task720.LongestWord(new[] {"a", "banana", "app", "appl", "ap", "apply", "apple"}));
            Assert.AreEqual("world", Task720.LongestWord(new[] {"w", "wo", "wor", "worl", "world"}));
            Assert.AreEqual("oiddm",
                Task720.LongestWord(new[]
                {
                    "k", "lg", "it", "oidd", "oid", "oiddm", "kfk", "y", "mw", "kf", "l", "o", "mwaqz", "oi", "ych",
                    "m", "mwa"
                }));
        }
        
        [Test]
        public void Should_LongestWord_Dfs()
        {
            Assert.AreEqual("apple", Task720.LongestWord_Dfs(new[] {"a", "banana", "app", "appl", "ap", "apply", "apple"}));
            Assert.AreEqual("world", Task720.LongestWord_Dfs(new[] {"w", "wo", "wor", "worl", "world"}));
            Assert.AreEqual("oiddm",
                Task720.LongestWord_Dfs(new[]
                {
                    "k", "lg", "it", "oidd", "oid", "oiddm", "kfk", "y", "mw", "kf", "l", "o", "mwaqz", "oi", "ych",
                    "m", "mwa"
                }));
        }
    }
}
