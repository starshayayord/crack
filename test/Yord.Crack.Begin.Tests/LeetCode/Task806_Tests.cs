using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task806_Tests
    {
        [Test]
        public void Should_NumberOfLines()
        {
            CollectionAssert.AreEqual(new[] {2, 4}, Task806.NumberOfLines(
                new[]
                {
                    4, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                    10
                },
                "bbbcccdddaaa"));
            CollectionAssert.AreEqual(new[] {3, 60}, Task806.NumberOfLines(
                new[]
                {
                    10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10,
                    10
                },
                "abcdefghijklmnopqrstuvwxyz"));
           
        }
    }
}
