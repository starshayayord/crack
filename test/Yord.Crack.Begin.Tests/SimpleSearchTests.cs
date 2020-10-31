using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class SimpleSearchTests
    {
        [Test]
        public void Should_FindIndex_SingleElement()
        {
            var sortedArray = new[] {3};
            const int element = 3;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(0, index);
            Assert.AreEqual(index, indexRec);
        }

        [Test]
        public void Should_FindIndex_TwoElements()
        {
            var sortedArray = new[] {1, 3};
            const int element = 3;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(1, index);
            Assert.AreEqual(index, indexRec);
        }

        [Test]
        public void Should_FindIndex_ThreeElements()
        {
            var sortedArray = new[] {1, 3, 7};
            const int element = 3;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(1, index);
            Assert.AreEqual(index, indexRec);
        }

        [Test]
        public void Should_FindIndex_MultipleElements1()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7};
            const int element = 3;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(3, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements2()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7, 8};
            const int element = 3;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(3, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements3()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7};
            const int element = 0;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(0, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements4()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7, 8};
            const int element = 0;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(0, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements5()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7, 8, 11, 12, 16, 32, 33};
            const int element = 0;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(0, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements6()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7, 8, 11, 12, 16, 32, 33};
            const int element = 1;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(1, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements7()
        {
            var sortedArray = new[] {0, 1, 2, 3, 7, 8, 11, 12, 16, 32, 33};
            const int element = 33;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(10, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements8()
        {
            var sortedArray = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            const int element = 9;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(9, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void Should_FindIndex_MultipleElements9()
        {
            var sortedArray = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
            const int element =11;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(11, index);
            Assert.AreEqual(index, indexRec);
        }
        
        [Test]
        public void ShouldNot_FindIndex_MultipleElements()
        {
            var sortedArray = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            const int element = 32;
            
            var index = SimpleSearch.GetIndex(sortedArray, element);
            var indexRec = SimpleSearch.GetIndexRec(sortedArray, element);

            Assert.AreEqual(-1, index);
            Assert.AreEqual(index, indexRec);
        }
    }
}
