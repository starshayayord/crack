using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task811_Tests
    {
        [Test]
        public void Should_SubdomainVisits()
        {
            CollectionAssert.AreEquivalent(new[] {"9001 discuss.leetcode.com", "9001 leetcode.com", "9001 com"},
                Task811.SubdomainVisits(new[] {"9001 discuss.leetcode.com"}));

            CollectionAssert.AreEquivalent(
                new[]
                {
                    "901 mail.com", "50 yahoo.com", "900 google.mail.com", "5 wiki.org", "5 org", "1 intel.mail.com",
                    "951 com"
                },
                Task811.SubdomainVisits(new[]
                {
                    "900 google.mail.com", "50 yahoo.com", "1 intel.mail.com", "5 wiki.org"
                }));
        }
    }
}
