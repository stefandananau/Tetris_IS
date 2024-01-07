using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Build;
using System.Threading;

namespace UnitTests
{
    [TestClass]
    public class StartOfGameTests
    {
        [TestMethod]
        public void ScoreStartsAtZero()
        {
            GameController.Get().Command(' '); //start the game
            Assert.AreEqual(0, GameController.Get().GetScore());
            GameController.Get().Stop();
        }

        [TestMethod]
        public void CurrentAndNextPieceAreCorrectlyConfiguredAtGameStart()
        {
            GameController.Get().Command(' '); //start the game
            Assert.IsTrue(GameController.Get().GetCurrent() != null);
            Assert.AreEqual(4, GameController.Get().GetCurrent().Count);
            Assert.IsTrue(GameController.Get().GetNext() != null);
            Assert.AreEqual(4, GameController.Get().GetNext().Count);
            GameController.Get().Stop();
        }

        [TestMethod]
        public void BoardIsEmptyAtGameStart()
        {
            GameController.Get().Command(' '); //start the game
            Assert.AreEqual(0, GameController.Get().GetState().Count);
            GameController.Get().Stop();
        }

        [TestMethod]
        public void NoSavedPieceAtGameStart()
        {
            GameController.Get().Command(' '); //start the game
            Assert.AreEqual(0, GameController.Get().GetSaved().Count);
            GameController.Get().Stop();
        }
    }
}
