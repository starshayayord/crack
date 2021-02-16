using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task3_Tests
    {
        [Test]
        public void Should_FindMagicIndex()
        {
            var arr = new[] {-10, -5, 0, 1, 3, 5, 8, 10, 12, 19};

            var magicIndex = Task3.FindMagicIndex(arr);

            Assert.AreEqual(5, magicIndex);
        }

        [Test]
        public void ShouldNot_FindMagicIndex()
        {
            var arr = new[] {-10, -5, 0, 1, 3, 4, 8, 10, 12, 19};

            var magicIndex = Task3.FindMagicIndex(arr);

            Assert.IsNull(magicIndex);
        }

        [Test]
        public void Should_FindMagicIndexRepeat1()
        {
            var arr = new[] {-10, -5, 2, 2, 2, 3, 4, 8, 9, 12, 13};

            var magicIndex = Task3.FindMagicIndexWithRepeats(arr);

            Assert.AreEqual(2, magicIndex);
        }

        [Test]
        public void Should_FindMagicIndexRepeat2()
        {
            var arr = new[] {-10, -5, 0, 2, 2, 3, 4, 7, 9, 12, 13};

            var magicIndex = Task3.FindMagicIndexWithRepeats(arr);

            Assert.AreEqual(7, magicIndex);
        }
        
        [Test]
        public void Should_FindMagicIndexRepeat1_Iter()
        {
            var arr = new[] {-10, -5, 2, 2, 2, 3, 4, 8, 9, 12, 13};

            var magicIndex = Task3.FindMagicIndexWithRepeatsIter(arr);

            Assert.AreEqual(2, magicIndex);
        }

        [Test]
        public void Should_FindMagicIndexRepeat2_Iter()
        {
            var arr = new[] {-10, -5, 0, 2, 2, 3, 4, 7, 9, 12, 13};

            var magicIndex = Task3.FindMagicIndexWithRepeatsIter(arr);

            Assert.AreEqual(7, magicIndex);
        }
        
        [Test]
        public void Should_FindMagicIndexRepeat3_Iter()
        {
            var arr = new[] {-10, 1, 1, 2, 2, 3, 4, 8, 9, 12, 13};

            var magicIndex = Task3.FindMagicIndexWithRepeatsIter(arr);

            Assert.AreEqual(1, magicIndex);
        }
    }
}
