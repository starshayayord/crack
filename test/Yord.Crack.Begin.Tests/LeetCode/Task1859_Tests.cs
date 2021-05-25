using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1859_Tests
    {
        [TestCase("is2 sentence4 This1 a3", ExpectedResult = "This is a sentence")]
        [TestCase("Myself2 Me1 I4 and3", ExpectedResult = "Me Myself and I")]
        public string Should_SortSentence(string s)
        {
            return Task1859.SortSentence(s);
        }
    }
}
