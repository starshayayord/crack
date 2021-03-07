using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task709_Tests
    {
        [TestCase("Hello", ExpectedResult = "hello")]
        [TestCase("here", ExpectedResult = "here")]
        [TestCase("LOVELY", ExpectedResult = "lovely")]
        public string Should_ConvertToLower(string s)
        {
            return Task709.ToLowerCase(s);
        }
    }
}
