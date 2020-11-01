using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class PermutationsTests
    {
        [Test]
        public void Should_GetPermutationsRec_Successfully()
        {
            var permutations = Permutations.GetPermutationsRecursion("abc");
            
            CollectionAssert.AreEquivalent(new[] {"cab", "abc", "acb", "cba", "bca", "bac"}, permutations);
        }
    }
}
