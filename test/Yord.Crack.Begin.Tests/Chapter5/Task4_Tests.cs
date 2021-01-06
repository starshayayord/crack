using NUnit.Framework;
using Yord.Crack.Begin.Chapter5;

namespace Yord.Crack.Begin.Tests.Chapter5
{
    [TestFixture]
    public class Task4_Tests
    {
        [Test]
        public void Should_GetClosestMinMaxSamiBits_Math()
        {
            var r = Task4.GetMaxMinSameBitsMath(13948);
            
            Assert.AreEqual(13946, r.Min);
            Assert.AreEqual(13967, r.Max);
        }
        
        [Test]
        public void Should_GetClosestMinMaxSamiBits()
        {
            var r = Task4.GetMaxMinSameBits(13948);
            
            Assert.AreEqual(13946, r.Min);
            Assert.AreEqual(13967, r.Max);
        }
    }
}
