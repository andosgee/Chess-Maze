namespace ChessMaze;

public class Level : ILevel
{
    public IBoard Board { get; private set; }
    public IPosition StartPosition { get; set; }
    public IPosition EndPosition { get; set; }
    public IPlayer Player { get; private set; }
    public bool IsCompleted { get; private set; }

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

}
