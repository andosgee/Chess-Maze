using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ChessMaze;

namespace ChessMazeTests
{
    [TestClass]
    public class GoalsTests
    {
        static LevelDesigner _levelDesigner = new LevelDesigner(8, 8, "Test Level");

        [TestMethod]
        public void AddGoalSingleTest()
        {
            // Arrange
            Position newGoal = new Position(1,6);
            
            // Act
            _levelDesigner.AddGoal(newGoal);
            var goalsList = _levelDesigner.GetGoals();

            //Assert
            Assert.IsTrue(goalsList.Contains(newGoal), "The goal should be in the List.");
        }

        [TestMethod]
        public void AddGoalsMultipleTest()
        {
            // Arrange
            var goal1 = new Position(1, 6);
            var goal2 = new Position(3, 4);
            var goal3 = new Position(5, 7);

            // Act
            _levelDesigner.AddGoal(goal1);
            _levelDesigner.AddGoal(goal2);
            _levelDesigner.AddGoal(goal3);

            var goalsList = _levelDesigner.GetGoals();

            // Assert
            Assert.IsTrue(goalsList.Contains(goal1), "The first goal should be in the list.");
            Assert.IsTrue(goalsList.Contains(goal2), "The second goal should be in the list.");
            Assert.IsTrue(goalsList.Contains(goal3), "The third goal should be in the list.");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddGoalsSingleOutBounds()
        {
            // Arrange
            var goal1 = new Position(300, 41);

            // Act
            _levelDesigner.AddGoal(goal1);

            // Assert
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AddGoalsMultipleOutBounds()
        {
            // Arrange
            var goal1 = new Position(3, 4);
            var goal2 = new Position(6, 7);
            var goal3 = new Position(30, 100);

            // Act
            _levelDesigner.AddGoal(goal1);
            _levelDesigner.AddGoal(goal2);
            _levelDesigner.AddGoal(goal3);

            var goalsList = _levelDesigner.GetGoals();

            // Assert
            Assert.IsTrue(goalsList.Contains(goal1), "The first goal should be in the list.");
            Assert.IsTrue(goalsList.Contains(goal2), "The second goal should be in the list.");
            Assert.IsTrue(goalsList.Contains(goal3), "The third goal should be in the list.");
        }

        [TestMethod]
        public void RemoveSingleGoal()
        {
            // Arrange
            var goal1 = new Position(3, 4);
            _levelDesigner.AddGoal(goal1);  // Add the goal to the list

            // Act
            _levelDesigner.RemoveGoal(goal1);  // Remove the goal
            var updatedGoalList = _levelDesigner.GetGoals();  // Get the goals after removal

            // Assert
            Assert.IsFalse(updatedGoalList.Contains(goal1), "The goal was found in the list after removal.");
        }

        [TestMethod]
        public void RemoveGoalsFromList()
        {
            // Arrange
            var goal1 = new Position(1, 6);
            var goal2 = new Position(3, 4);
            var goal3 = new Position(5, 7);
            var goal4 = new Position(6, 7);

            // Act
            _levelDesigner.AddGoal(goal1);
            _levelDesigner.AddGoal(goal2);
            _levelDesigner.AddGoal(goal3);
            _levelDesigner.AddGoal(goal4);

            _levelDesigner.RemoveGoal(goal3);
            _levelDesigner.RemoveGoal(goal1);

            var goalsList = _levelDesigner.GetGoals();

            // Assert
            Assert.IsTrue(goalsList.Contains(goal2), "The second goal should be in the list.");
            Assert.IsTrue(goalsList.Contains(goal4), "The fourth goal should be in the list.");
            Assert.IsFalse(goalsList.Contains(goal1), "The first goal should not be in the list.");
            Assert.IsFalse(goalsList.Contains(goal3), "The third goal should not be in the list.");
            Assert.AreEqual(2, goalsList.Count(), "The goals list should contain exactly 2 goals.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void RemoveGoalNotListed()
        {
            // Arrange
            var goal1 = new Position(6,5);

            // Act
            _levelDesigner.RemoveGoal(goal1);

            // Assert

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RemoveGoalOutsaideBounds()
        {
            // Arrange
            var goal1 = new Position(30, -1);

            // Act
            _levelDesigner.RemoveGoal(goal1);

            // Assert

        }

        [TestMethod]
        public void RemoveAllGoals()
        {
            // Arrange
            var goal1 = new Position(1, 6);
            var goal2 = new Position(3, 4);
            var goal3 = new Position(5, 7);
            var goal4 = new Position(6, 7);

            // Act
            _levelDesigner.AddGoal(goal1);
            _levelDesigner.AddGoal(goal2);
            _levelDesigner.AddGoal(goal3);
            _levelDesigner.AddGoal(goal4);

            _levelDesigner.RemoveAllGoals();
            var goalsList = _levelDesigner.GetGoals();

            // Assert
            Assert.AreEqual(0, goalsList.Count(), "The goals list should be empty after removing all goals.");
        }
    }
}
