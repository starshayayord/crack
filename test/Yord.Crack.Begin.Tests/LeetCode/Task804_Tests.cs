using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task804_Tests
    {
        [Test]
        public void Should_UniqueMorseRepresentations_Map()
        {
            Assert.AreEqual(2,Task804.UniqueMorseRepresentations_Map(new []{"gin", "zen", "gig", "msg"}));
        }
        
        [Test]
        public void Should_UniqueMorseRepresentations()
        {
            Assert.AreEqual(2,Task804.UniqueMorseRepresentations(new []{"gin", "zen", "gig", "msg"}));
        }
    }
}
