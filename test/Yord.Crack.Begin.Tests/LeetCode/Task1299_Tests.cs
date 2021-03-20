using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1299_Tests
    {
        [Test]
        public void Should_ReplaceElements()
        {
            CollectionAssert.AreEqual(new[]{18,6,6,6,1,-1},Task1299.ReplaceElements(new [] {17,18,5,4,6,1}));
            CollectionAssert.AreEqual(new[]{-1},Task1299.ReplaceElements(new [] {400}));
        }
    }
}
