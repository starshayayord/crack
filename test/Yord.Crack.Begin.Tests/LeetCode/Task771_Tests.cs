using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task771_Tests
    {
        [Test]
        public void Should_CheckJewels()
        {
            var jewels = "aA";
            var stones = "aAAbbbb";
            
            Assert.AreEqual(3, Task771.NumJewelsInStonesSpace2(jewels, stones));
        }
    }
}
