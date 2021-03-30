using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1078_Tests
    {
        [Test]
        public void Should_FindOccurrences()
        {
            CollectionAssert.AreEqual(new[] {"girl","student"},
                Task1078.FindOccurrences("alice is a good girl she is a good student", "a", "good"));
            
            CollectionAssert.AreEqual(new[] {"we","rock"},
                Task1078.FindOccurrences("we will we will rock you", "we", "will"));
        }
    }
}
