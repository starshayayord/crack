using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task8_Tests
    {
        [Test]
        public void Should_GetPermutations()
        {
            var src = "aab";

            var permutations = Task8.GetPermutations(src);
            
            CollectionAssert.AreEquivalent(new []
            {
                "aab",
                "aba",
                "baa"
            }, permutations);
        }
    }
}
