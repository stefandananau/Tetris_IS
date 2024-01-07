using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Build;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class PieceMovementTests
    {
        [TestMethod]
        public void MoveLeft()
        {
            GameController.Get().Command(' '); //start the game
            var xValues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                xValues[i] = GameController.Get().GetCurrent().ElementAt(i).X;
            }
            GameController.Get().Command('a');

            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(xValues[i] - 1, GameController.Get().GetCurrent().ElementAt(i).X);
            }
            GameController.Get().Stop();
        }

        [TestMethod]
        public void MoveRight()
        {
            GameController.Get().Command(' '); //start the game
            var xValues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                xValues[i] = GameController.Get().GetCurrent().ElementAt(i).X;
            }
            GameController.Get().Command('d');
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(xValues[i] + 1, GameController.Get().GetCurrent().ElementAt(i).X);
            }
            GameController.Get().Stop();
        }

        [TestMethod]
        public void MoveDown()
        {
            GameController.Get().Command(' '); //start the game
            var yValues = new int[4];
            for (int i = 0; i < 4; i++)
            {
                yValues[i] = GameController.Get().GetCurrent().ElementAt(i).Y;
            }
            GameController.Get().Command('s');
            for (int i = 0; i < 4; i++)
            {
                Assert.AreEqual(yValues[i] + 1, GameController.Get().GetCurrent().ElementAt(i).Y);
            }
            GameController.Get().Stop();
        }
    }
}
