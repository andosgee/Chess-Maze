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
    IPosition StartPosition { get; set; }

    /// <summary>
    /// Gets the end position for this level.
    /// </summary>
    IPosition EndPosition { get; set; }

    /// <summary>
    /// Gets the player for this level.
    /// </summary>
    IPlayer Player { get; }

    /// <summary>
    /// Determines if the level is completed.
    /// </summary>
    bool IsCompleted { get; }

    /// <summary>
    /// 
    /// </summary>
    IEnumerable<IPosition> Goals { get; }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="position"></param>
    void AddGoal(IPosition position);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="position"></param>
    void RemoveGoal(IPosition position);

    /// <summary>
    /// 
    /// </summary>
    void RemoveAllGoals();
}