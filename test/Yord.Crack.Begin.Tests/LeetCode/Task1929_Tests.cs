using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1929_Tests
    {
        [Test]
        public void Should_GetConcatenation()
        {
            CollectionAssert.AreEqual(new[] {1, 2, 1, 1, 2, 1}, Task1929.GetConcatenation(new[] {1, 2, 1}));
            CollectionAssert.AreEqual(new[] {1, 3, 2, 1, 1, 3, 2, 1}, Task1929.GetConcatenation(new[] {1, 3, 2, 1}));
        }
        
        [Test]
        public void Should_GetConcatenation2()
        {
            CollectionAssert.AreEqual(new[] {1, 2, 1, 1, 2, 1}, Task1929.GetConcatenation2(new[] {1, 2, 1}));
            CollectionAssert.AreEqual(new[] {1, 3, 2, 1, 1, 3, 2, 1}, Task1929.GetConcatenation2(new[] {1, 3, 2, 1}));
        }
        
        [Test]
        public void Should_GetConcatenation3()
        {
            CollectionAssert.AreEqual(new[] {1, 2, 1, 1, 2, 1}, Task1929.GetConcatenation3(new[] {1, 2, 1}));
            CollectionAssert.AreEqual(new[] {1, 3, 2, 1, 1, 3, 2, 1}, Task1929.GetConcatenation3(new[] {1, 3, 2, 1}));
        }
    }
}
