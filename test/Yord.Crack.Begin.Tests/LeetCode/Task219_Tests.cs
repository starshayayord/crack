using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task219_Tests
    {
        [Test]
        public void Should_ContainsNearbyDuplicate()
        {
            Assert.IsTrue(Task219.ContainsNearbyDuplicate(new[] {1, 2, 3, 1}, 3));
            Assert.IsTrue(Task219.ContainsNearbyDuplicate(new[] {1, 0, 1, 1,}, 1));
            Assert.IsFalse(Task219.ContainsNearbyDuplicate(new[] {1, 2, 3, 1, 2, 3}, 2));
        }
        
        [Test]
        public void Should_ContainsNearbyDuplicate_Window()
        {
            Assert.IsTrue(Task219.ContainsNearbyDuplicate_Window(new[] {1, 2, 3, 1}, 3));
            Assert.IsTrue(Task219.ContainsNearbyDuplicate_Window(new[] {1, 0, 1, 1,}, 1));
            Assert.IsFalse(Task219.ContainsNearbyDuplicate_Window(new[] {1, 2, 3, 1, 2, 3}, 2));
        }
    }
}
