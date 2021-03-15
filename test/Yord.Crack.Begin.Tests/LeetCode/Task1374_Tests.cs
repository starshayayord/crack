using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1374_Tests
    {
        
        [TestCase(4, ExpectedResult = "zppp")]
        [TestCase(1, ExpectedResult = "p")]
        public string Should_GenerateTheString(int n)
        {
            return Task1374.GenerateTheString(n);
        }
        
    }
}
