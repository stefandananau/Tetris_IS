using Logic.Build;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTests
{
    [TestClass]
    public class SpecialCommands
    {
        [TestMethod]
        public void PieceSave()
        {
            GameController.Get().Command(' '); //start the game
            GameController.Get().Command('q'); //save piece
            Assert.AreEqual(4, GameController.Get().GetSaved().Count);
            GameController.Get().Stop();
        }

        [TestMethod]
        public void DropPiece()
        {
            GameController.Get().Command(' '); //start the game
            Thread.Sleep(1000);
            GameController.Get().Command(' '); //drop piece
            Thread.Sleep(1000);
            Assert.AreEqual(4, GameController.Get().GetState().Count);
            GameController.Get().Stop();
        }
    }
}
