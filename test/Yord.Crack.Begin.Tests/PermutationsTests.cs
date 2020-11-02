using NUnit.Framework;

namespace Yord.Crack.Begin.Tests
{
    [TestFixture]
    public class PermutationsTests
    {
        [Test]
        public void Should_GetPer_Successfully()
        {
            var permutations = Permutations.GetPer("abc");
            
            CollectionAssert.AreEquivalent(new[] {"cab", "abc", "acb", "cba", "bca", "bac"}, permutations);
        }
        
        [Test]
        public void Should_GetPer_Successfully2()
        {
            var permutations = Permutations.GetPer("a");
            
            CollectionAssert.AreEquivalent(new[] {"a"}, permutations);
        }
        
        [Test]
        public void Should_GetPer_Successfully3()
        {
            var permutations = Permutations.GetPer("ab");
            
            CollectionAssert.AreEquivalent(new[] {"ab", "ba"}, permutations);
        }
    }
}
