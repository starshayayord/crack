using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1351_Tests
    {
        [Test]
        public void Should_FindNegative()
        {
            Assert.AreEqual(8, Task1351.CountNegatives(new[]
            {
                new[] {4, 3, 2, -1},
                new[] {3, 2, 1, -1},
                new[] {1, 1, -1, -2},
                new[] {-1, -1, -2, -3}
            }));

            Assert.AreEqual(0, Task1351.CountNegatives(new[]
            {
                new[] {3, 2},
                new[] {1, 0}
            }));

            Assert.AreEqual(3, Task1351.CountNegatives(new[]
            {
                new[] {1, -1},
                new[] {-1, -1}
            }));

            Assert.AreEqual(1, Task1351.CountNegatives(new[]
            {
                new[] {-1},
            }));
        }
        
        [Test]
        public void Should_FindNegative_BS()
        {
            Assert.AreEqual(8, Task1351.CountNegatives_BS(new[]
            {
                new[] {4, 3, 2, -1},
                new[] {3, 2, 1, -1},
                new[] {1, 1, -1, -2},
                new[] {-1, -1, -2, -3}
            }));

            Assert.AreEqual(0, Task1351.CountNegatives_BS(new[]
            {
                new[] {3, 2},
                new[] {1, 0}
            }));

            Assert.AreEqual(3, Task1351.CountNegatives(new[]
            {
                new[] {1, -1},
                new[] {-1, -1}
            }));

            Assert.AreEqual(1, Task1351.CountNegatives_BS(new[]
            {
                new[] {-1},
            }));
        }
    }
}
