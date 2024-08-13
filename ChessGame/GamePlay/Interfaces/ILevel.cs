/// <summary>
/// Represents a level in the Chess Maze game.
/// </summary>
public interface ILevel
{
    /// <summary>
    /// Gets the game board for this level.
    /// </summary>
    IBoard Board { get; }

    /// <summary>
    /// Gets the start position for this level.
    /// </summary>
    IPosition StartPosition { get; }

    /// <summary>
    /// Gets the end position for this level.
    /// </summary>
    IPosition EndPosition { get; }

    /// <summary>
    /// Gets the player for this level.
    /// </summary>
    IPlayer Player { get; }

    /// <summary>
    /// Determines if the level is completed.
    /// </summary>
    bool IsCompleted { get; }
}