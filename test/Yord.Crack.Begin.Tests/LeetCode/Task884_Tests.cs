using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task884_Tests
    {
        [Test]
        public void Should_UncommonFromSentences()
        {
            CollectionAssert.AreEquivalent(new[] {"sweet", "sour"},
                Task884.UncommonFromSentences("this apple is sweet", "this apple is sour"));

            CollectionAssert.AreEquivalent(new[] {"banana"},
                Task884.UncommonFromSentences("apple apple", "banana"));
        }
    }
}
