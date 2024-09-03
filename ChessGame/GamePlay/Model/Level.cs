namespace ChessMaze;

public class Level : ILevel
{
    public IBoard Board { get; private set; }
    public IPosition StartPosition { get; set; }
    public IPosition EndPosition { get; set; }
    public IPlayer Player { get; private set; }
    public bool IsCompleted { get; private set; }
    private List<IPosition> goals = new List<IPosition>();
    public IEnumerable<IPosition> Goals => goals;

    /// <summary>
    /// Constructor for the level.
    /// </summary>
    /// <param name="board">Board for the level</param>
    /// <param name="startPosition">Starting postion for the level</param>
    /// <param name="endPosition">Emd Position for the board</param>
    /// <param name="player">The players position the board</param>
    public Level(IBoard board, IPosition startPosition, IPosition endPosition, IPlayer player)
    {
        Board = board;
        StartPosition = startPosition;
        EndPosition = endPosition;
        Player = player;
        IsCompleted = false;
    }

    /// <summary>
    /// Sets the level to complete once solved.
    /// </summary>
    public void CompleteLevel()
    {
        IsCompleted = true;
    }

    /// <summary>
    /// Adds a goal to the list
    /// </summary>
    /// <param name="position">Takes position of the goal</param>
    public void AddGoal(IPosition position)
    {
        goals.Add(position);
    }

    /// <summary>
    /// Removes a goal at a given position
    /// </summary>
    /// <param name="position">Takes position of the goal</param>
    /// <exception cref="ArgumentException">Throws an error if the goal does not exist</exception>
    public void RemoveGoal(IPosition position)
    {
        if (!goals.Contains(position))
        {
            throw new ArgumentException("The goal is not in the list.", nameof(position));
        }
        goals.Remove(position);
    }

    /// <summary>
    /// Removes all goals from the list
    /// </summary>
    public void RemoveAllGoals()
    {
        goals.Clear();
    }

}
