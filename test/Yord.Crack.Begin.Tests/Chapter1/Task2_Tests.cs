using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task2_Tests
    {
        [Test]
        public void Should_CheckIsPermutation_Successfully()
        {
            Assert.IsTrue(Task2.IsPermutation("abba", "baba"));
        }
        
        [Test]
        public void Should_CheckIsPermutation_Successfully2()
        {
            Assert.IsFalse(Task2.IsPermutation("abba", "abbb"));
        }
        
        [Test]
        public void Should_CheckIsPermutation2_Successfully()
        {
            Assert.IsTrue(Task2.IsPermutation("abba", "baba"));
        }
        
        [Test]
        public void Should_CheckIsPermutation2_Successfully2()
        {
            Assert.IsFalse(Task2.IsPermutation("abba", "abbb"));
        }
    }
}
