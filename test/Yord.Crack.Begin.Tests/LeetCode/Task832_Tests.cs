using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task832_Tests
    {
        [Test]
        public void Should_FlipAndInvertImage()
        {
            var image = Task832.FlipAndInvertImage(new[]
            {
                new[] {1, 1, 0},
                new[] {1, 0, 1},
                new[] {0, 0, 0}
            });
            CollectionAssert.AreEqual(new[]
            {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {1, 1, 1}
            }, image);
        }
        
        [Test]
        public void Should_FlipAndInvertImage_2()
        {
            var image = Task832.FlipAndInvertImage_2(new[]
            {
                new[] {1, 1, 0},
                new[] {1, 0, 1},
                new[] {0, 0, 0}
            });
            CollectionAssert.AreEqual(new[]
            {
                new[] {1, 0, 0},
                new[] {0, 1, 0},
                new[] {1, 1, 1}
            }, image);
        }

        [Test]
        public void Should_FlipAndInvertImage2()
        {
            var image = Task832.FlipAndInvertImage(new[]
            {
                new[] {1, 1, 0, 0},
                new[] {1, 0, 0, 1},
                new[] {0, 1, 1, 1},
                new[] {1, 0, 1, 0}
            });
            CollectionAssert.AreEqual(new[]
            {
                new[] {1, 1, 0, 0},
                new[] {0, 1, 1, 0},
                new[] {0, 0, 0, 1},
                new[] {1, 0, 1, 0}
            }, image);
        }
        
        [Test]
        public void Should_FlipAndInvertImage2_2()
        {
            var image = Task832.FlipAndInvertImage_2(new[]
            {
                new[] {1, 1, 0, 0},
                new[] {1, 0, 0, 1},
                new[] {0, 1, 1, 1},
                new[] {1, 0, 1, 0}
            });
            CollectionAssert.AreEqual(new[]
            {
                new[] {1, 1, 0, 0},
                new[] {0, 1, 1, 0},
                new[] {0, 0, 0, 1},
                new[] {1, 0, 1, 0}
            }, image);
        }
    }
}
