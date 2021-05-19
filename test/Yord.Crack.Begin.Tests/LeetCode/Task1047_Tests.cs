using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1047_Tests
    {
        [TestCase("abbaca", ExpectedResult = "ca")]
        [TestCase("azxxzy", ExpectedResult = "ay")]
        public string Should_RemoveDuplicatesStack(string s)
        {
            return Task1047.RemoveDuplicatesStack(s);
        }

        [TestCase("abbaca", ExpectedResult = "ca")]
        [TestCase("azxxzy", ExpectedResult = "ay")]
        public string Should_RemoveDuplicates(string s)
        {
            return Task1047.RemoveDuplicates(s);
        }
    }
}
