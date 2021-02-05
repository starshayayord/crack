using System.Collections.Generic;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter7;

namespace Yord.Crack.Begin.Tests.Chapter7
{
    [TestFixture]
    public class Task9_Tests
    {
        [Test]
        public void Should_Rotate_Successfully()
        {
            var ca = Initiate(10);
            Assert.AreEqual(0, ca[0]);
            ca.Rotate(1);
            Assert.AreEqual(10, ca[0]);
            ca.Rotate(-2);
            Assert.AreEqual(90, ca[0]);
        }
        
        [Test]
        public void Should_Enumerate_Successfully()
        {
            var ca = Initiate(10);
            ca.Rotate(5);
            var list = new List<int>();
            foreach (var c in ca)
            {
                list.Add(c);
            }
            
            CollectionAssert.AreEqual(list, ca);
            CollectionAssert.AreEqual(new [] {50, 60, 70, 80, 90, 0, 10, 20, 30, 40}, ca);
        }

        private Task9.CircularArray<int> Initiate(int size)
        {
            var ca = new Task9.CircularArray<int>(size);
            for (var i = 0; i < size; i++)
            {
                ca[i] = i * 10;
            }

            return ca;
        }
    }
}
