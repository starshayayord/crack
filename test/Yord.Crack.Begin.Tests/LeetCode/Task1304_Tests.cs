using System.Linq;
using NUnit.Framework;
using Yord.Crack.Begin.LeetCode;

namespace Yord.Crack.Begin.Tests.LeetCode
{
    [TestFixture]
    public class Task1304_Tests
    {
        [Test]
        public void Should_GenerateArr_Odd()
        {
            int n =5;
            
            var a = Task1304.SumZero(n);
            
            Assert.AreEqual(n, a.Length);
            Assert.AreEqual(0, a.Sum());
            Assert.AreEqual(a.Distinct().Count(), a.Length);
        }
        
        [Test]
        public void Should_GenerateArr_15()
        {
            int n =15;
            
            var a = Task1304.SumZero(n);
            
            Assert.AreEqual(n, a.Length);
            Assert.AreEqual(0, a.Sum());
            Assert.AreEqual(a.Distinct().Count(), a.Length);
        }
        
        [Test]
        public void Should_GenerateArr_Even()
        {
            int n =4;
            
            var a = Task1304.SumZero(n);
            
            Assert.AreEqual(n, a.Length);
            Assert.AreEqual(0, a.Sum());
            Assert.AreEqual(a.Distinct().Count(), a.Length);
        }
        
        [Test]
        public void Should_GenerateArr_1()
        {
            int n =0;
            
            var a = Task1304.SumZero(n);
            
            Assert.AreEqual(n, a.Length);
            Assert.AreEqual(0, a.Sum());
            Assert.AreEqual(a.Distinct().Count(), a.Length);
        }
        
        [Test]
        public void Should_GenerateArr_22()
        {
            int n =22;
            
            var a = Task1304.SumZero(n);
            
            Assert.AreEqual(n, a.Length);
            Assert.AreEqual(0, a.Sum());
            Assert.AreEqual(a.Distinct().Count(), a.Length);
        }
    }
}
