using NUnit.Framework;
using Yord.Crack.Begin.Chapter8;

namespace Yord.Crack.Begin.Tests.Chapter8
{
    [TestFixture]
    public class Task5_Tests
    {
        [TestCase(arg1: 1, arg2: 1, ExpectedResult = 1)]
        [TestCase(arg1: 1, arg2: 10, ExpectedResult = 10)]
        [TestCase(arg1: 5, arg2: 5, ExpectedResult = 25)]
        [TestCase(arg1: 71, arg2: 165, ExpectedResult = 11715)]
        [TestCase(arg1: 165, arg2: 71, ExpectedResult = 11715)]
        public int Should_Multiply(int a, int b)
        {
            return Task5.Multiply(a, b);
        }

        [TestCase(arg1: 1, arg2: 1, ExpectedResult = 1)]
        [TestCase(arg1: 1, arg2: 10, ExpectedResult = 10)]
        [TestCase(arg1: 5, arg2: 5, ExpectedResult = 25)]
        [TestCase(arg1: 71, arg2: 165, ExpectedResult = 11715)]
        [TestCase(arg1: 165, arg2: 71, ExpectedResult = 11715)]
        public int Should_MultiplyRec(int a, int b)
        {
            return Task5.MultiplyRec(a, b);
        }
    }
}
