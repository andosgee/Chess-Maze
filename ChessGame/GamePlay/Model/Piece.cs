namespace ChessMaze;

public class Piece : IPiece
{
    public PieceType Type { get; private set; }

    /// <summary>
    /// Constructor for the piece type
    /// </summary>
    /// <param name="type">Type of piece</param>
    public Piece(PieceType type)
    {
        Type = type;
    }
}
