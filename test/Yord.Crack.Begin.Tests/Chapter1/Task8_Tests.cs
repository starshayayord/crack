using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task8_Tests
    {
        [Test]
        public void Should_ReplaceElements_Successfully()
        {
            var source = new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 0, 8},
                new[] {0, 10, 11, 12}
            };
            
            var replaced = Task8.ToZero(source);
            CollectionAssert.AreEqual(new[] {0, 2, 0, 4}, replaced[0]);
            CollectionAssert.AreEqual(new[] {0, 0, 0, 0}, replaced[1]);
            CollectionAssert.AreEqual(new[] {0, 0, 0, 0}, replaced[2]);
        }
        
        [Test]
        public void Should_ReplaceElements2_Successfully()
        {
            var source = new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 0, 8},
                new[] {0, 10, 11, 12}
            };
            
            var replaced = Task8.ToZero2(source);
            CollectionAssert.AreEqual(new[] {0, 2, 0, 4}, replaced[0]);
            CollectionAssert.AreEqual(new[] {0, 0, 0, 0}, replaced[1]);
            CollectionAssert.AreEqual(new[] {0, 0, 0, 0}, replaced[2]);
        }
    }
}
