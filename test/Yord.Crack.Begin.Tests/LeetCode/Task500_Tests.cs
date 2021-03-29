using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task500_Tests
    {
        [Test]
        public void Should_FindWords()
        {
            CollectionAssert.AreEquivalent(new[] {"Alaska", "Dad"},
                Task500.FindWords(new[] {"Hello", "Alaska", "Dad", "Peace"}));

            CollectionAssert.AreEquivalent(new string [0], Task500.FindWords(new []{"omk"}));

            CollectionAssert.AreEquivalent(new[] {"adsdf", "sfd"}, Task500.FindWords(new[] {"adsdf", "sfd"}));
        }
    }
}
