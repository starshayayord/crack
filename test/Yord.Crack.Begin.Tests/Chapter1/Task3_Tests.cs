using NUnit.Framework;
using Yord.Crack.Begin.Chapter1;

namespace Yord.Crack.Begin.Tests.Chapter1
{
    [TestFixture]
    public class Task3_Tests
    {
        
        
        [TestCase("", ExpectedResult = "")]
        [TestCase(" ", ExpectedResult = "%20")]
        [TestCase(" Test ", ExpectedResult = "%20Test%20")]
        [TestCase(" More complicated  test ", ExpectedResult = "%20More%20complicated%20%20test%20")]
        public string Should_ReplaceSpaces1_Successfully(string source)
        {
            return Task3.ReplaceSpaces1(source);
        }

        [Test]
        public void Should_ReplaceSpaces_AdditionalConditions()
        {
            var result = Task3.ReplaceSpaces2("Test case here    ".ToCharArray(), 14);
            
            Assert.AreEqual("Test%20case%20here", new string(result));
        }
        
        [TestCase("", ExpectedResult = "")]
        [TestCase(" ", ExpectedResult = "%20")]
        [TestCase(" Test ", ExpectedResult = "%20Test%20")]
        [TestCase(" More complicated  test ", ExpectedResult = "%20More%20complicated%20%20test%20")]
        public string Should_ReplaceSpaces3_Successfully(string source)
        {
            return Task3.ReplaceSpaces3(source);
        }
    }
}
