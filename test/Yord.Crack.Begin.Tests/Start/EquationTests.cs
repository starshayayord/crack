using System;
using System.Linq;
using NUnit.Framework;
using Yord.Crack.Begin.Start;

namespace Yord.Crack.Begin.Tests.Start
{
    [TestFixture]
    public class EquationTests
    {
        private Equation _equation;
        [SetUp]
        public void SetUp()
        {
            _equation = new Equation();
        }
        
        [Test]
        public void Should_FindAllSolutions()
        {
            var solutions = _equation.FindSolutions();
            Assert.IsTrue(solutions.All(s => Math.Pow(s.A, 3) + Math.Pow(s.B, 3) == Math.Pow(s.C, 3) + Math.Pow(s.D, 3)));
        }
    }
}
