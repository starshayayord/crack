using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task6_Tests
    {
        [TestCase("", ExpectedResult = "")]
        [TestCase("aa", ExpectedResult = "aa")]
        [TestCase("aabbcccca", ExpectedResult = "a2b2c4a1")]
        public string Should_CompressString_Successfully(string source)
        {
            return Task6.Compress(source);
        }
    }
}
