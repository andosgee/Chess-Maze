/// <summary>
/// Represents a game session in the Chess Maze game.
/// </summary>
public interface IGame
{
    /// <summary>
    /// Gets the current level being played.
    /// </summary>
    ILevel CurrentLevel { get; }

    /// <summary>
    /// Loads a specified level into the game.
    /// </summary>
    /// <param name="aLevel">The level to load.</param>
    void LoadLevel(ILevel aLevel);

    /// <summary>
    /// Attempts to make a move to a new position.
    /// </summary>
    /// <param name="newPosition">The new position to move to.</param>
    /// <returns>True if the move is successful, otherwise false.</returns>
    bool MakeMove(IPosition newPosition);

    /// <summary>
    /// Determines if the game is over.
    /// </summary>
    bool IsGameOver { get; }

    /// <summary>
    /// Gets the count of moves made in the current game.
    /// </summary>
    /// <returns>The number of moves made.</returns>
    int GetMoveCount();

    /// <summary>
    /// Undoes the last move made in the game.
    /// </summary>
    void Undo();

    /// <summary>
    /// Restarts the current game level.
    /// </summary>
    void Restart();
}