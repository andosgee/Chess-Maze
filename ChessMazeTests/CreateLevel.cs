using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ChessMaze;

namespace ChessMazeTests
{
    [TestClass]
    public class CreateLevelTests
    {
        [TestMethod]
        public void Constructor_ShouldInitLevelDesigner()
        {
            // Arrange
            int width = 8;
            int height = 8;
            string levelName = "Test Level";

            // Act
            LevelDesigner levelDesigner = new LevelDesigner(width,height,levelName);

            Assert.IsNotNull(levelDesigner.Board, "Board should be initialized.");
            Assert.IsNotNull(levelDesigner.GetBoardSize(), "Board size should be initialized.");
            Assert.AreEqual(levelName, levelDesigner.GetLevelName(), "Level name should be set correctly.");
            Assert.AreEqual(width, levelDesigner.GetBoardSize()[0], "Board width should be set correctly.");
            Assert.AreEqual(height, levelDesigner.GetBoardSize()[1], "Board height should be set correctly.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ShouldThrowException_WhenWidthIsZero()
        {
            // Arrange
            int width = 0;
            int height = 8;
            string levelName = "Test Level";

            // Act
            var levelDesigner = new LevelDesigner(width, height, levelName);

            // Assert
            // Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ShouldThrowException_WhenHeightIsZero()
        {
            // Arrange
            int width = 8;
            int height = 0;
            string levelName = "Test Level";

            // Act
            var levelDesigner = new LevelDesigner(width, height, levelName);

            // Assert
            // Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_ShouldThrowException_WhenNameIsNull()
        {
            // Arrange
            int width = 8;
            int height = 8;
            string levelName = null;

            // Act
            var levelDesigner = new LevelDesigner(width, height, levelName);

            // Assert
            // Expects exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_ShouldThrowException_WhenWidthOrHeightIsNegative()
        {
            // Arrange
            int width = -5;
            int height = 8;
            string levelName = "Test Level";

            // Act
            var levelDesigner = new LevelDesigner(width, height, levelName);

            // Assert
            // Expects exception
        }

    }
}