using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task217_Tests
    {
        [Test]
        public void Should_ContainsDuplicate_Bit()
        {
            Assert.IsTrue(Task217.ContainsDuplicate_Bit(new []{1,2,3,1}));
            Assert.IsFalse(Task217.ContainsDuplicate_Bit(new []{1,2,3,4}));
            Assert.IsTrue(Task217.ContainsDuplicate_Bit(new []{1,1,1,3,3,4,3,2,4,2}));
        }
        
        [Test]
        public void Should_ContainsDuplicate()
        {
            Assert.IsTrue(Task217.ContainsDuplicate(new []{1,2,3,1}));
            Assert.IsFalse(Task217.ContainsDuplicate(new []{1,2,3,4}));
            Assert.IsTrue(Task217.ContainsDuplicate(new []{1,1,1,3,3,4,3,2,4,2}));
        }
    }
}
