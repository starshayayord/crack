using System;
using NUnit.Framework;
using Yord.Crack.Begin.Chapter4;

namespace Yord.Crack.Begin.Tests.Chapter4
{
    [TestFixture]
    public class Task7_Tests
    {
        [Test]
        public void Should_GetOrder2_Successfully()
        {
            var deps = new[]
            {
                new Tuple<char, char>('d', 'a'), new Tuple<char, char>('b', 'f'), new Tuple<char, char>('d', 'b'),
                new Tuple<char, char>('a', 'f'), new Tuple<char, char>('c', 'd')
            };
            
            var order = Task7.GetOrder2(new[] {'a', 'b', 'c', 'd', 'e', 'f'}, deps);
            
            CollectionAssert.AreEqual(new[] {'e', 'f', 'a', 'b', 'd', 'c'}, order);
        }
        
        [Test]
        public void ShouldNot_GetOrder_WhenCycle()
        {
            var deps = new[]
            {
                new Tuple<char, char>('a', 'b'), new Tuple<char, char>('b', 'c'), new Tuple<char, char>('c', 'a'),
            };
            
            var order = Task7.GetOrder2(new[] {'a', 'b', 'c', 'd'}, deps);
            
            Assert.IsNull(order);
        }
    }
}
