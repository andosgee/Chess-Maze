using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ChessMaze;

namespace ChessMazeTests
{
    [TestClass]
    public class RemovePieces
    {
        static LevelDesigner _levelDesigner = new LevelDesigner(8, 8, "Test Level");
        static Position _removalPosition = new Position(1, 3);
        static Position _outOfBounds = new Position(9, 2);

        [TestMethod]
        public void RemovePieceWithValidBounds()
        {
            _levelDesigner.PlacePiece(PieceType.King, _removalPosition);
            var kingAt = _levelDesigner.GetPieceAt(_removalPosition);
            _levelDesigner.RemovePiece(_removalPosition);
            var emptyAt = _levelDesigner.GetPieceAt(_removalPosition);

            Assert.AreEqual(PieceType.King, kingAt.Type);
            Assert.AreEqual(PieceType.Empty, emptyAt.Type);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RemovePieceWithoutValidBounds()
        {
            _levelDesigner.PlacePiece(PieceType.King, _removalPosition);
            _levelDesigner.RemovePiece(_outOfBounds);
        }
    }
}
