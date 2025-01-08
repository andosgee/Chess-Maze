using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ChessMaze;

namespace ChessMazeTests
{
    [TestClass]
    public class ChangeBoardParametersTests
    {
        static LevelDesigner _levelDesigner = new LevelDesigner(8, 8, "Test Level");

        [TestMethod]
        public void TestIncreaseBoardSize()
        {
            // Arrange
            int newWidth = 10;
            int newHeight = 10;
            _levelDesigner.SetBoardSize(newWidth, newHeight);

            // Act
            int[] newSize = _levelDesigner.GetBoardSize();
            var pieceAtNewPosition = _levelDesigner.GetPieceAt(new Position(9, 9));

            // Assert
            Assert.AreEqual(newWidth, newSize[0], "Board width should have increased to 10.");
            Assert.AreEqual(newHeight, newSize[1], "Board height should have increased to 10.");
            Assert.AreEqual(PieceType.Empty, pieceAtNewPosition.Type, "Newly added cells should be initialised to Empty.");

        }

        [TestMethod]
        public void TestDecreaseBoardSize()
        {
            // Arrange
            int newWidth = 5;
            int newHeight = 5;
            _levelDesigner.SetBoardSize(newWidth, newHeight);

            // Act
            int[] newSize = _levelDesigner.GetBoardSize();
            var pieceAtNewPosition = _levelDesigner.GetPieceAt(new Position(4, 4));

            // Assert
            Assert.AreEqual(newWidth, newSize[0], "Board width should have increased to 5.");
            Assert.AreEqual(newHeight, newSize[1], "Board height should have increased to 5.");
            Assert.AreEqual(PieceType.Empty, pieceAtNewPosition.Type, "Newly added cells should be initialised to Empty.");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestDecreaseNegativeThrowError()
        {
            // Arrange
            int newWidth = -3;
            int newHeight = 3;
            _levelDesigner.SetBoardSize(newWidth, newHeight);

            // Act
            // Assert
        }

        [TestMethod]
        public void TestSetNewName()
        {
            // Arrange
            string newName = "Easy Level 1";
            _levelDesigner.SetLevelName(newName);

            // Act
            var boardName = _levelDesigner.GetLevelName();

            // Assert
            Assert.AreEqual(newName, boardName, "Board name should be Easy Level 1");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSetNameWhiteSpace()
        {
            // Arrange
            string newName = "";
            _levelDesigner.SetLevelName(newName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSetNameNull()
        {
            // Arrange
            string newName = null;
            _levelDesigner.SetLevelName(newName);
        }

        [TestMethod]
        public void TestChangeStartPosition()
        {
            // Arrange
            Position newStart = new Position(1, 3);

            // Act
            _levelDesigner.SetStartPosition(newStart);

            // Assert
            Assert.AreEqual(newStart, _levelDesigner.GetStartPosition(), "Start Position should be 1,3");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestChangeOutOfBoundsStart()
        {
            // Arrange
            Position start = new Position(-1, 10);

            // Act
            _levelDesigner.SetStartPosition(start);
        }

        [TestMethod]
        public void TestChangeEndPosition()
        {
            // Arrange
            Position newEnd = new Position(7, 4);

            // Act
            _levelDesigner.SetEndPosition(newEnd);

            // Assert
            Assert.AreEqual(newEnd, _levelDesigner.GetEndPosition(), "End Position should be 7,4");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestChangeOutOfBoundsEnd()
        {
            // Arrange
            Position end = new Position(10, -60);

            // Act
            _levelDesigner.SetEndPosition(end);
        }
    }
}