using NUnit.Framework;
using Yord.Crack.Begin.DataStructures;

namespace Yord.Crack.Begin.Tests.DataStructures
{
    [TestFixture]
    public class SimpleStringBuilderTests
    {
        [Test]
        public void Should_Append_Successfully()
        {
            var sb = new SimpleStringBuilder();
            
            sb.Append("ab");
            
            Assert.AreEqual(2, sb.Length);
            Assert.AreEqual("ab", sb.ToString());
        }
        
        [Test]
        public void Should_Append_WithResize()
        {
            var sb = new SimpleStringBuilder(2);
            
            sb.Append("abcd");
            
            Assert.AreEqual(4, sb.Length);
            Assert.AreEqual("abcd", sb.ToString());
        }
        
        [Test]
        public void Should_Clear_Successfully()
        {
            var sb = new SimpleStringBuilder(2);
            sb.Append("abcd");
            sb.Clear();
            
            Assert.AreEqual(0, sb.Length);
            Assert.AreEqual("", sb.ToString());
        }
    
    }
}
