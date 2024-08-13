/// <summary>
/// Represents a player in the Chess Maze game.
/// </summary>
public interface IPlayer
{
    /// <summary>
    /// Gets or sets the current position of the player on the board.
    /// </summary>
    IPosition CurrentPosition { get; set; }

    /// <summary>
    /// Determines if the player can move to a new position on the board.
    /// </summary>
    /// <param name="newPosition">The new position to move to.</param>
    /// <param name="board">The game board.</param>
    /// <returns>True if the move is possible, otherwise false.</returns>
    bool CanMove(IPosition newPosition, IBoard board);

    /// <summary>
    /// Moves the player to a new position on the board.
    /// </summary>
    /// <param name="newPosition">The new position to move to.</param>
    /// <param name="board">The game board.</param>
    void Move(IPosition newPosition, IBoard board);
}