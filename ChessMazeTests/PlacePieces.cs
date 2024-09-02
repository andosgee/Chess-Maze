using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using ChessMaze;

namespace ChessMazeTests 
{

    [TestClass]
    public class PlacePieceTests
    {
        /// <summary>
        /// Constructor for the tests
        /// </summary>
        static LevelDesigner _levelDesigner = new LevelDesigner(8, 8, "Test Level");
        static Position _emptyPosition = new Position(2, 5);
        static Position _kingPosition = new Position(6, 3);
        static Position _rookPosition = new Position(1, 7);
        static Position _bishopPosition = new Position(4, 4);
        static Position _knightPosition = new Position(7, 2);
        static Position _pawnPosition = new Position(0, 6);

        [TestMethod]
        public void TestPlaceKing()
        {
            _levelDesigner.PlacePiece(PieceType.King, _kingPosition);
            var piece = _levelDesigner.GetPieceAt(_kingPosition);
            Assert.AreEqual(PieceType.King, piece.Type, "The piece at the position should be a King.");
        }

        [TestMethod]
        public void TestPlaceRook()
        {
            _levelDesigner.PlacePiece(PieceType.Rook, _rookPosition);
            var piece = _levelDesigner.GetPieceAt(_rookPosition);
            Assert.AreEqual(PieceType.Rook, piece.Type, "The piece at the position should be a Rook.");
        }

        [TestMethod]
        public void TestPlaceBishop()
        {
            _levelDesigner.PlacePiece(PieceType.Bishop, _bishopPosition);
            var piece = _levelDesigner.GetPieceAt(_bishopPosition);
            Assert.IsNotNull(piece, "Piece should not be null.");
            Assert.AreEqual(PieceType.Bishop, piece.Type, "The piece at the position should be a Bishop.");
        }

        [TestMethod]
        public void TestPlaceKnight()
        {
            _levelDesigner.PlacePiece(PieceType.Knight, _knightPosition);
            var piece = _levelDesigner.GetPieceAt(_knightPosition);
            Assert.AreEqual(PieceType.Knight, piece.Type, "The piece at the position should be a Knight.");
        }

        [TestMethod]
        public void TestPlacePawn()
        {
            _levelDesigner.PlacePiece(PieceType.Pawn, _pawnPosition);
            var piece = _levelDesigner.GetPieceAt(_pawnPosition);
            Assert.AreEqual(PieceType.Pawn, piece.Type, "The piece at the position should be a Pawn.");
        }

        [TestMethod]
        public void TestPlaceEmpty()
        {
            _levelDesigner.PlacePiece(PieceType.Empty, _emptyPosition);
            var piece = _levelDesigner.GetPieceAt(_emptyPosition);
            Assert.AreEqual(PieceType.Empty, piece.Type, "The piece at the position should be a Pawn.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestPlaceInvalidPiece()
        {
            _levelDesigner.PlacePiece((PieceType)165, _emptyPosition);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestPlacePieceOutOfBounds()
        {
            var outOfBoundsPosition = new Position(9, 9);
            _levelDesigner.PlacePiece(PieceType.Knight, outOfBoundsPosition);
        }
    }
}
