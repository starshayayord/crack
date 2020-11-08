using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task1_Tests
    {
        [TestCase("ab", ExpectedResult = true)]
        [TestCase("abb", ExpectedResult = false)]
        public bool Should_CheckUniq1_WithHashMap(string s)
        {
            return Task1.IsUniqSymbols(s);
        }
        
        [TestCase("ab", ExpectedResult = true)]
        [TestCase("abb", ExpectedResult = false)]
        public bool Should_CheckUniq2_WithHashMap(string s)
        {
            return Task1.IsUniqSymbols2(s);
        }
        
        [TestCase("ab", ExpectedResult = true)]
        [TestCase("abb", ExpectedResult = false)]
        public bool Should_CheckUniq3_WithASCIIArray(string s)
        {
            return Task1.IsUniqSymbols3(s);
        }
        
        [TestCase("ab", ExpectedResult = true)]
        [TestCase("abb", ExpectedResult = false)]
        public bool Should_IsUniqueChars_WithASCIIArray(string s)
        {
            return Task1.IsUniqueChars(s);
        }
    }
}
