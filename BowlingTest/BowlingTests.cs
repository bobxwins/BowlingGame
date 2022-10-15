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
            ThrowMultiple(0,1);
            Assert.AreEqual(0, game.CalcScore());

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
            Assert.AreEqual(11, game.CalcScore());
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
                
                game.Throws(pinsDown);
            
            }
        }
        private void throwStrike ()
        {
            game.Throws(10);
            game.Throws(1);
            game.Throws(1);
            ThrowMultiple(0, 16);
        }
        private void throwSpare()
        {
            game.Throws(7);
            game.Throws(3);
            game.Throws(1);
            ThrowMultiple(0, 17);
        }
    }
}
