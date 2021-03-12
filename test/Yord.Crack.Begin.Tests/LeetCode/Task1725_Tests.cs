using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1725_Tests
    {
        [Test]
        public void Should_CountGoodRectangles()
        {
            Assert.AreEqual(3, Task1725.CountGoodRectangles(new []
            {
                new[] {5, 8},
                new[] {3, 9},
                new[] {5, 12},
                new[] {16, 5}
            }));
            
            Assert.AreEqual(3, Task1725.CountGoodRectangles(new []
            {
                new[] {2, 3},
                new[] {3, 7},
                new[] {4, 3},
                new[] {3, 7}
            }));
        }
    }
}
