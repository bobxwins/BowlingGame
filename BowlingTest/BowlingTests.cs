using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bowling;

namespace BowlingTest
{
    [TestClass]
    public class BowlingTests
    {
        private BowlingGame game;

        [TestInitialize]
        public void canMakeGame()
        {
            game = new BowlingGame();
        }


        [TestMethod]
        public void canThrowBall()
        {
            game.Throw(7);
            Assert.AreEqual(7, game.CalcScore());

        }


        [TestMethod]
        public void canScoreOnes()
        {
           
                ThrowMultiple(1, 20);
                Assert.AreEqual(20, game.CalcScore());   

        }

        [TestMethod]
        public void canScoreGutter()
        {
            ThrowMultiple(0, 20);
            Assert.AreEqual(0, game.CalcScore());

        }

        [TestMethod]
        public void canScoreSpareAndOne()
        {
            throwSpare();
            Assert.AreEqual(16, game.CalcScore());
        }

        [TestMethod]
        public void canScoreStrike()
        {
            throwStrike();
            Assert.AreEqual(14, game.CalcScore());
        
        }
        private void ThrowMultiple(int pinsDown, int throwCount)
        {
            for (int i = 0; i < throwCount; i++)
            {
                
                game.Throw(pinsDown);
            
            }
        }
        private void throwStrike ()
        {
            game.Throw(10);
            game.Throw(1);
            game.Throw(1);
            ThrowMultiple(0, 16);
        }
        private void throwSpare()
        {
            game.Throw(7);
            game.Throw(3);
            game.Throw(3);
            ThrowMultiple(0, 17);
        }
    }
}
