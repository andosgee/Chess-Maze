namespace ChessMaze.Interfaces
{
    public interface IBoard
    {
        int Rows { get; }
        int Columns { get; }
        PieceType[,] Cells { get; }
        IPiece GetPieceAt(IPosition position);
        void PlacePiece(IPiece piece, IPosition position);
        void RemovePiece(IPosition position);
        void MovePiece(IPosition from, IPosition to);
        bool IsValidPosition(IPosition position);
        bool IsMoveLegal(IPosition from, IPosition to);
    }
}