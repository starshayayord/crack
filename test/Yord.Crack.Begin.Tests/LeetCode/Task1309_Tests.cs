using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1309_Tests
    {
        [TestCase("10#11#12", ExpectedResult = "jkab")]
        [TestCase("1326#", ExpectedResult = "acz")]
        [TestCase("25#", ExpectedResult = "y")]
        [TestCase("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        public string Should_FreqAlphabets(string s)
        {
            return Task1309.FreqAlphabets(s);
        }
        
        [TestCase("10#11#12", ExpectedResult = "jkab")]
        [TestCase("1326#", ExpectedResult = "acz")]
        [TestCase("25#", ExpectedResult = "y")]
        [TestCase("12345678910#11#12#13#14#15#16#17#18#19#20#21#22#23#24#25#26#", ExpectedResult = "abcdefghijklmnopqrstuvwxyz")]
        public string Should_FreqAlphabets_2(string s)
        {
            return Task1309.FreqAlphabets_2(s);
        }
        
    }
}
