using NUnit.Framework;
using Yord.Crack.Begin.Chapter6;

namespace Yord.Crack.Begin.Tests.Chapter6
{
    [TestFixture]
    public class Task7_Tests
    {
        [Test]
        public void Should_CalcGirlsPercent()
        {
            var genNumbers = 1000000;
            var girlsPercent = Task7.GetGirlsPercent(genNumbers);
            Assert.Greater(girlsPercent, 0.4 );
            Assert.Less(girlsPercent, 0.6);
        }
    }
}
