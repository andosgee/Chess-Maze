/// <summary>
/// Represents a position on the chess board with row and column coordinates.
/// </summary>
public interface IPosition
{
    /// <summary>
    /// Gets the row number of the position.
    /// </summary>
    int Row { get; }

    /// <summary>
    /// Gets the column number of the position.
    /// </summary>
    int Column { get; }
}