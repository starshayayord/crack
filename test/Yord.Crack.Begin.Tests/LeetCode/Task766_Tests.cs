using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task766_Tests
    {
        [Test]
        public void Should_IsToeplitzMatrix()
        {
            Assert.IsTrue(Task766.IsToeplitzMatrix(new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 1, 2, 3},
                new[] {9, 5, 1, 2}
            }));
            Assert.IsFalse(Task766.IsToeplitzMatrix(new[] {new[] {1, 2,}, new[] {2, 2}}));
        }
    }
}
