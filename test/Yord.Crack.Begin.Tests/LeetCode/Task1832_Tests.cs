using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1832_Tests
    {
        [TestCase("thequickbrownfoxjumpsoverthelazydog", ExpectedResult = true)]
        [TestCase("leetcode", ExpectedResult = false)]
        public bool Should_CheckIfPangram(string s)
        {
            return Task1832.CheckIfPangram(s);
        }
        
        [TestCase("thequickbrownfoxjumpsoverthelazydog", ExpectedResult = true)]
        [TestCase("leetcode", ExpectedResult = false)]
        public bool Should_CheckIfPangram2(string s)
        {
            return Task1832.CheckIfPangram2(s);
        }
    }
}
