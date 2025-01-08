/// <summary>
/// Provides functionality for designing levels in the Chess Maze game.
/// </summary>
public interface ILevelDesigner
{
    /// <summary>
    /// Gets the board being designed.
    /// </summary>
    IBoard Board { get; }

    /// <summary>
    /// Sets the size of the board.
    /// </summary>
    /// <param name="rows">The number of rows.</param>
    /// <param name="columns">The number of columns.</param>
    void SetBoardSize(int rows, int columns);

    /// <summary>
    /// Places a piece of a specific type at a given position.
    /// </summary>
    /// <param name="type">The type of piece to place.</param>
    /// <param name="position">The position to place the piece at.</param>
    void PlacePiece(PieceType type, IPosition position);

    /// <summary>
    /// Removes a piece from a given position.
    /// </summary>
    /// <param name="position">The position to remove the piece from.</param>
    void RemovePiece(IPosition position);

    /// <summary>
    /// Sets the start position for the level.
    /// </summary>
    /// <param name="position">The start position.</param>
    void SetStartPosition(IPosition position);

    /// <summary>
    /// Sets the end position for the level.
    /// </summary>
    /// <param name="position">The end position.</param>
    void SetEndPosition(IPosition position);

    /// <summary>
    /// Creates a new level with the specified width and height.
    /// </summary>
    /// <param name="width">The width of the level.</param>
    /// <param name="height">The height of the level.</param>
    /// <returns>The created level.</returns>
    ILevel CreateLevel(int width, int height);
}