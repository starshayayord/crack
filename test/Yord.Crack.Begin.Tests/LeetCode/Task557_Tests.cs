using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task557_Tests
    {
        [TestCase("Let's take LeetCode contest", ExpectedResult = "s'teL ekat edoCteeL tsetnoc")]
        [TestCase("God Ding", ExpectedResult = "doG gniD")]
        public string Should_ReverseWords(string s)
        {
            return Task557.ReverseWords(s);
        }
    }
}
