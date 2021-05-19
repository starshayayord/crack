using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task344_Tests
    {
        [Test]
        public void Should_ReverseString()
        {
            var chars = new[] {'h', 'e', 'l', 'l', 'o'};
            Task344.ReverseString(chars);
            CollectionAssert.AreEqual(new[] {'o', 'l', 'l', 'e', 'h'}, chars);
        }
        
        [Test]
        public void Should_ReverseStringXor()
        {
            var chars = new[] {'h', 'e', 'l', 'l', 'o'};
            Task344.ReverseStringXor(chars);
            CollectionAssert.AreEqual(new[] {'o', 'l', 'l', 'e', 'h'}, chars);
        }
        
        [Test]
        public void Should_ReverseStringRev()
        {
            var chars = new[] {'h', 'e', 'l', 'l', 'o'};
            Task344.ReverseStringRev(chars);
            CollectionAssert.AreEqual(new[] {'o', 'l', 'l', 'e', 'h'}, chars);
        }
    }
}
