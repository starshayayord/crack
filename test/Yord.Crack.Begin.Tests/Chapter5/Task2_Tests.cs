using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task2_Tests
    {
        [TestCase(0.5, ExpectedResult = "0.1")]
        [TestCase(0.625, ExpectedResult = "0.101")]
        public string Should_Convert(double num)
        {
            return Task2.Convert(num);
        }
    }
}
