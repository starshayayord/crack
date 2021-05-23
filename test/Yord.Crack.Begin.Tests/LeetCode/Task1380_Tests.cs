using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1380_Tests
    {
        [Test]
        public void Should_LuckyNumbers()
        {
            CollectionAssert.AreEqual(new[] {12}, Task1380.LuckyNumbers(new[]
            {
                new[] {1, 10, 4, 2},
                new[] {9, 3, 8, 7}, 
                new[] {15, 16, 17, 12}
            }));
            
            CollectionAssert.AreEqual(new[] {15}, Task1380.LuckyNumbers(new[]
            {
                new[] {3, 7, 8},
                new[] {9, 11, 13},
                new[] {15, 16, 17}
            }));

           

            CollectionAssert.AreEqual(new[] {7}, Task1380.LuckyNumbers(new[]
            {
                new[] {7, 8}, new[] {1, 2}
            }));
        }
    }
}
