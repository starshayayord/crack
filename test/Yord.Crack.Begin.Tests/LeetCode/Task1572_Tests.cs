using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1572_Tests
    {
        [Test]
        public void Should_SumDiagonal_Odd()
        {
            var sum = Task1572.DiagonalSum(new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            });
            
            var sum2 = Task1572.DiagonalSum_2(new[]
            {
                new[] {1, 2, 3},
                new[] {4, 5, 6},
                new[] {7, 8, 9}
            });

            Assert.AreEqual(25, sum);
            Assert.AreEqual(25, sum2);
        }

        [Test]
        public void Should_SumDiagonal_Even()
        {
            var sum = Task1572.DiagonalSum(new[]
            {
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
            });
            
            
            var sum2 = Task1572.DiagonalSum_2(new[]
            {
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
                new[] {1, 1, 1, 1},
            });

            Assert.AreEqual(8, sum);
            Assert.AreEqual(8, sum2);
        }
    }
}
