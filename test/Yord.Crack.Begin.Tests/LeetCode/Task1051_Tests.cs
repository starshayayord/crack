using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1051_Tests
    {

        [Test]
        public void Should_HeightChecker()
        {
            Assert.AreEqual(3, Task1051.HeightChecker(new []{1,1,4,2,1,3}));
            Assert.AreEqual(5, Task1051.HeightChecker(new []{5,1,2,3,4}));
            Assert.AreEqual(0, Task1051.HeightChecker(new []{1,2,3,4,5}));
        }
    }
}
