using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1768_Tests
    {
        [TestCase("abc", "pqr", ExpectedResult = "apbqcr")]
        [TestCase("ab", "pqrs", ExpectedResult = "apbqrs")]
        [TestCase("abcd", "pq", ExpectedResult = "apbqcd")]
        public string Should_MergeAlternately(string w1, string w2)
        {
            return Task1768.MergeAlternately(w1, w2);
        }
    }
}
