using CrossAndZeroes;
using NUnit.Framework;

namespace CrossAndZeroesTests
{
    public class GameTests
    {
        #region NextStep

        [Test]
        public void StatusShouldNotBeFinishedWhenTheGameIsNotCompleted()
        {
            // Arrange
            Board b = new Board();
            Game g = new Game(b, MakerType.Cross);

            // Act
            g.NextStep(0, 0);

            g.NextStep(2, 2);

            g.NextStep(0, 1);

            g.NextStep(2, 1);


            // Assert
            Assert.IsFalse(g.Status.IsFinished);
        }

        [Test]
        public void StatusShouldBeFinishedWhenGameIsCompleted()
        {
            // Arrange
            Board b = new Board();
            Game g = new Game(b, MakerType.Cross);

            // Act
            g.NextStep(0, 0);

            g.NextStep(2, 2);

            g.NextStep(0, 1);

            g.NextStep(2, 1);

            g.NextStep(0, 2);

            // Assert
            Assert.IsTrue(g.Status.IsFinished);
        }

        #endregion
    }
}