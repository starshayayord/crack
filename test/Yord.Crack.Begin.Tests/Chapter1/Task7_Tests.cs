using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task7_Tests
    {
        [Test]
        public void Should_RotateMatrix_Successfully()
        {
            var source = new[,]
            {
                {1, 2},
                {3, 4}
            };

            var rotated = Task7.Rotate(source);
            Assert.AreEqual(source[0, 0], rotated[1, 0]);
            Assert.AreEqual(source[0, 1], rotated[1, 1]);
            Assert.AreEqual(source[1, 0], rotated[0, 0]);
            Assert.AreEqual(source[1, 1], rotated[0, 1]);
        }

        [Test]
        public void Should_RotateMatrix2_Successfully()
        {
            var source = new[]
            {
                new[] {1, 2, 3, 4},
                new[] {5, 6, 7, 8},
                new[] {9, 10, 11, 12},
                new[] {13, 14, 15, 16},
            };
            var rotated = Task7.RotateClockwise(source);
            CollectionAssert.AreEqual(new[] {13, 9, 5, 1}, rotated[0]);
            CollectionAssert.AreEqual(new[] {14, 10, 6, 2}, rotated[1]);
            CollectionAssert.AreEqual(new[] {15, 11, 7, 3}, rotated[2]);
            CollectionAssert.AreEqual(new[] {16, 12, 8, 4}, rotated[3]);
        }
    }
}
