using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
        Game game;
        public GameFixture()
        {
        }


        [TestMethod]



        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }

        [TestMethod]
        //public void Hookup()
        //{
        //    Assert(true);
        //}

        [Test]
        public void GutterBalls()
        {
            SetUp();
            ManyOpenFrames(10, 0, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void Threes()
        {
            ManyOpenFrames(10, 3, 3);
            Assert.AreEqual(60, game.Score());
        }

        [Test]
        public void Spare()
        {
            game.Spare(4, 6);
            game.OpenFrame(3, 5);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(21, game.Score());
        }

        [Test]
        public void Spare2()
        {
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(23, game.Score());
        }

        [Test]
        public void Strike()
        {
            game.Strike();
            game.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(26, game.Score());
        }

        [Test]
        public void StrikeFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            game.Strike();
            game.BonusRoll(5);
            game.BonusRoll(3);
            Assert.AreEqual(18, game.Score()); // note that this is different from test Strike()
        }

        [Test]
        public void SpareFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            game.Spare(4, 6);
            game.BonusRoll(5);
            Assert.AreEqual(15, game.Score());
        }

        [Test]
        public void Perfect()
        {
            for (int i = 0; i < 10; i++)
                game.Strike();
            game.BonusRoll(10);
            game.BonusRoll(10);
            Assert.AreEqual(300, game.Score());
        }

        [Test]
        public void Alternating()
        {
            for (int i = 0; i < 5; i++)
            {
                game.Strike();
                game.Spare(4, 6);
            }
            game.BonusRoll(10);
            Assert.AreEqual(200, game.Score());
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
                game.OpenFrame(firstThrow, secondThrow);
        }
    }
    //public void Gutter_game_score_should_be_zero_test()
    //{
    //    var game = new Game();
    //    Roll(game, 0, 20);
    //    Assert.AreEqual(0, game.GetScore());
    //}

    //private void Roll(Game game, int pins, int times)
    //{
    //    for (int i = 0; i < times; i++)
    //    {
    //        game.Roll(pins);
    //    }
    //}
}

