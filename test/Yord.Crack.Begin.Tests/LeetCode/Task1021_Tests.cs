using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1021_Tests
    {
        [TestCase("(()())(())", ExpectedResult = "()()()")]
        [TestCase("(()())(())(()(()))", ExpectedResult = "()()()()(())")]
        [TestCase("()()", ExpectedResult = "")]
        public string Should_RemoveOuterParentheses(string s)
        {
            return Task1021.RemoveOuterParentheses(s);
        }
    }
}
