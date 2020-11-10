using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task4_Tests
    {
        [TestCase("Tact Coa", ExpectedResult = true)]
        [TestCase("Test", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = true)]
        [TestCase("tattarrattat", ExpectedResult = true)]
        [TestCase("madam racecar E", ExpectedResult = true)]
        public bool Should_CheckPalindrome_Successfully(string str)
        {
            return Task4.IsPalindromePermutation(str);
        }
        
        [TestCase("Tact Coa", ExpectedResult = true)]
        [TestCase("Test", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = true)]
        [TestCase("tattarrattat", ExpectedResult = true)]
        [TestCase("madam racecar E", ExpectedResult = true)]
        [TestCase("madam2 racecar E1", ExpectedResult = true)]
        public bool Should_CheckPalindrome2_Successfully(string str)
        {
            return Task4.IsPalindromePermutation2(str);
        }
        
        [TestCase("Tact Coa", ExpectedResult = true)]
        [TestCase("Test", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = true)]
        [TestCase("tattarrattat", ExpectedResult = true)]
        [TestCase("madam racecar E", ExpectedResult = true)]
        [TestCase("madam2 racecar E1", ExpectedResult = true)]
        public bool Should_CheckPalindrome3_Successfully(string str)
        {
            return Task4.IsPalindromePermutation3(str);
        }
        
        [TestCase("Tact Coa", ExpectedResult = true)]
        [TestCase("Test", ExpectedResult = false)]
        [TestCase(" ", ExpectedResult = true)]
        [TestCase("tattarrattat", ExpectedResult = true)]
        [TestCase("madam racecar E", ExpectedResult = true)]
        [TestCase("madam2 racecar E1", ExpectedResult = true)]
        public bool Should_CheckPalindrome4_Successfully(string str)
        {
            return Task4.IsPalindromePermutation4(str);
        }
    }
}
