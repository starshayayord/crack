using NUnit.Framework;
using Yord.Crack.Begin.Chapter6;

namespace Yord.Crack.Begin.Tests.Chapter6
{
    [TestFixture]
    public class Task8_Tests
    {
        
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(12, ExpectedResult = 12)]
        [TestCase(13, ExpectedResult = 13)]
        [TestCase(14, ExpectedResult = 14)]
        [TestCase(15, ExpectedResult = 15)]
        [TestCase(16, ExpectedResult = 16)]
        [TestCase(17, ExpectedResult = 17)]
        [TestCase(18, ExpectedResult = 18)]
        [TestCase(19, ExpectedResult = 19)]
        [TestCase(20, ExpectedResult = 20)]
        [TestCase(21, ExpectedResult = 21)]
        [TestCase(22, ExpectedResult = 22)]
        [TestCase(23, ExpectedResult = 23)]
        [TestCase(24, ExpectedResult = 24)]
        [TestCase(25, ExpectedResult = 25)]
        public int Should_FindNFloor2(int n)
        {
            return Task8.GetFloor2(n);
        }
        
        [TestCase(11, ExpectedResult = 11)]
        [TestCase(12, ExpectedResult = 12)]
        [TestCase(13, ExpectedResult = 13)]
        [TestCase(14, ExpectedResult = 14)]
        [TestCase(15, ExpectedResult = 15)]
        [TestCase(16, ExpectedResult = 16)]
        [TestCase(17, ExpectedResult = 17)]
        [TestCase(18, ExpectedResult = 18)]
        [TestCase(19, ExpectedResult = 19)]
        [TestCase(20, ExpectedResult = 20)]
        [TestCase(21, ExpectedResult = 21)]
        [TestCase(22, ExpectedResult = 22)]
        [TestCase(23, ExpectedResult = 23)]
        [TestCase(24, ExpectedResult = 24)]
        [TestCase(25, ExpectedResult = 25)]
        public int Should_FindNFloor(int n)
        {
            return Task8.GetFloor(n);
        }
        
    }
}
