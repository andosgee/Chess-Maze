namespace ChessMaze;

public class Position : IPosition
{
    public int Row { get; private set; }
    public int Column { get; private set; }

    /// <summary>
    /// Constructor for the Position Class
    /// </summary>
    /// <param name="row">The row of the position</param>
    /// <param name="column">The column of the position</param>
    public Position(int row, int column)
    {
        Row = row;
        Column = column;
    }
}