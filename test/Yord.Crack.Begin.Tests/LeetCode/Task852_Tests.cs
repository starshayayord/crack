using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task852_Tests
    {
        [Test]
        public void Should_PeakIndexInMountainArray()
        {
            Assert.AreEqual(1, Task852.PeakIndexInMountainArrayN(new[] {0, 1, 0}));
            Assert.AreEqual(1, Task852.PeakIndexInMountainArrayN(new[] {0, 2, 1, 0}));
            Assert.AreEqual(1, Task852.PeakIndexInMountainArrayN(new[] {0, 10, 5, 2}));
            Assert.AreEqual(2, Task852.PeakIndexInMountainArrayN(new[] {3, 4, 5, 1}));
            Assert.AreEqual(2, Task852.PeakIndexInMountainArrayN(new[] {24, 69, 100, 99, 79, 78, 67, 36, 26, 19}));
        }
        
        [Test]
        public void Should_PeakIndexInMountainArray_BinSearch()
        {
            Assert.AreEqual(1, Task852.PeakIndexInMountainArray(new[] {0, 1, 0}));
            Assert.AreEqual(1, Task852.PeakIndexInMountainArray(new[] {0, 2, 1, 0}));
            Assert.AreEqual(1, Task852.PeakIndexInMountainArray(new[] {0, 10, 5, 2}));
            Assert.AreEqual(2, Task852.PeakIndexInMountainArray(new[] {3, 4, 5, 1}));
            Assert.AreEqual(2, Task852.PeakIndexInMountainArray(new[] {24, 69, 100, 99, 79, 78, 67, 36, 26, 19}));
        }
    }
}
