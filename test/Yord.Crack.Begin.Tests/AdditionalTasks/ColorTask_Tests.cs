using NUnit.Framework;
using Yord.Crack.Begin.AdditionalTasks;

namespace Yord.Crack.Begin.Tests.AdditionalTasks
{
    [TestFixture]
    public class ColorTask_Tests
    {
        [Test]
        public void Should_ColorMatrix()
        {
            var matrix = new[,]
            {
                {'Y', 'B', 'B', 'Y'},
                {'B', 'B', 'Y', 'Y'},
                {'Y', 'B', 'Y', 'Y'},
                {'Y', 'Y', 'B', 'B'}
            };
            ColorTask.ColorPart(matrix, 'R', 2, 1);
            Assert.AreEqual(new[,]
            {
                {'Y', 'R', 'R', 'Y'},
                {'R', 'R', 'Y', 'Y'},
                {'Y', 'R', 'Y', 'Y'},
                {'Y', 'Y', 'B', 'B'}
            }, matrix);
        }
        
        [Test]
        public void Should_ColorMatrix2()
        {
            var matrix = new[,]
            {
                {'Y', 'B', 'B', 'Y'},
                {'B', 'B', 'Y', 'Y'},
                {'Y', 'B', 'Y', 'Y'},
                {'Y', 'Y', 'B', 'B'}
            };
            ColorTask.ColorPart2(matrix, 'R', 2, 1);
            Assert.AreEqual(new[,]
            {
                {'Y', 'R', 'R', 'Y'},
                {'R', 'R', 'Y', 'Y'},
                {'Y', 'R', 'Y', 'Y'},
                {'Y', 'Y', 'B', 'B'}
            }, matrix);
        }
    }
}
