using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1704_Tests
    {
        [TestCase("book", ExpectedResult = true)]
        [TestCase("textbook", ExpectedResult = false)]
        [TestCase("MerryChristmas", ExpectedResult = false)]
        [TestCase("AbCdEfGh", ExpectedResult = true)]
        public bool Should_HalvesAreAlike(string s)
        {
            return Task1704.HalvesAreAlike(s);
        }
    }
}
