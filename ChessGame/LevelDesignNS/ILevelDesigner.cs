namespace ChessMaze.LevelDesignNS
{
    public interface ILevelDesigner
    {
        IBoard Board { get; }
        void SetBoardSize(int rows, int columns);
        void PlacePiece(PieceType type, IPosition position);
        void RemovePiece(IPosition position);
        void SetStartPosition(IPosition position);
        void SetEndPosition(IPosition position);
        ILevel CreateLevel(int width, int height);
    }
}
