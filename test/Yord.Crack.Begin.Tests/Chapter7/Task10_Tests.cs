using NUnit.Framework;
using Yord.Crack.Begin.Chapter7;

namespace Yord.Crack.Begin.Tests.Chapter7
{
    [TestFixture]
    public class Task10_Tests
    {
        [Test]
        public void Should_PlayGame()
        {
            var game = new Task10.Game(1, 2, 1);
            game.Start();
            
            game.Play("B0 0");
            Assert.AreEqual(Task10.GameState.Running, game.GameState);
            Assert.AreEqual(1, game.Unexposed);
            
            game.Play("B0 0");
            Assert.AreEqual(Task10.GameState.Running, game.GameState);
            Assert.AreEqual(1, game.Unexposed);
            
            var result = game.Play("0 0");
            if (result) // бомба с первого хода
            {
                Assert.AreEqual(Task10.GameState.Lost, game.GameState);
                Assert.AreEqual(1, game.Unexposed);
            }
            else // бомба со второго хода
            {
                Assert.AreEqual(Task10.GameState.Won, game.GameState);
                Assert.AreEqual(0, game.Unexposed);
            }
        }
        
    }
}
