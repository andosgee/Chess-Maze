namespace ChessMaze;

public class Player : IPlayer
{
    public IPosition CurrentPosition { get; set; }

    /// <summary>
    /// Constructor for the player
    /// </summary>
    /// <param name="startingPosition">Takes the starting point of the player</param>
    public Player(IPosition startingPosition)
    {
        CurrentPosition = startingPosition;
    }

    /// <summary>
    /// Checks if the player can move.
    /// </summary>
    /// <param name="newPosition">New position set for the player</param>
    /// <param name="board">Board that the player is playing on</param>
    /// <returns>Returns true if the player can move there, otherwise false for illegal move.</returns>
    public bool CanMove(IPosition newPosition, IBoard board)
    {
        // Move Logic will go here -> outside scope
        return board.IsValidPosition(newPosition);
    }

    /// <summary>
    /// Moves the player
    /// </summary>
    /// <param name="newPosition">New position set for the player</param>
    /// <param name="board">Board that the player is playing on</param>
    /// <exception cref="ArgumentException">Invalid move exception</exception>
    public void Move(IPosition newPosition, IBoard board)
    {
        if (CanMove(newPosition, board))
        {
            CurrentPosition = newPosition;
        }
        else
        {
            throw new ArgumentException("Invalid move.");
        }
    }
}