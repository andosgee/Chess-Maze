﻿namespace ChessMaze;

public class Board : IBoard
{
    public int Rows { get; internal set; }
    public int Columns { get; internal set; }
    public PieceType[,] Cells { get; internal set; }

    /// <summary>
    /// Constructor of the Board Class
    /// </summary>
    /// <param name="rows">The amount of rows in the board</param>
    /// <param name="columns">The amount of columns in the board</param>
    public Board(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        Cells = new PieceType[rows, columns];
    }

    /// <summary>
    /// Get the piece at a given position
    /// </summary>
    /// <param name="position">Position that the user enters</param>
    /// <returns>Returns null if not a valid position, else returns the piece at the position</returns>
    /// <exception cref="ArgumentNullException">Throws an error if the position is empty or null</exception>
    public IPiece GetPieceAt(IPosition position)
    {
        if (position == null)
        {
            throw new ArgumentNullException(nameof(position), "Position cannot be null.");
        }
        PieceType pieceType = Cells[position.Row, position.Column];
        return new Piece(pieceType);
    }

    /// <summary>
    /// Places a piece at a position assuming it is valid.
    /// </summary>
    /// <param name="piece">The piece to place</param>
    /// <param name="position">The position for the piece</param>
    public void PlacePiece(IPiece piece, IPosition position)
    {
        Cells[position.Row, position.Column] = piece.Type;
    }


    /// <summary>
    /// Removes a piece from the board
    /// </summary>
    /// <param name="position">Postion that the piece is removed from</param>
    public void RemovePiece(IPosition position)
    {
        Cells[position.Row, position.Column] = PieceType.Empty;
    }

    /// <summary>
    /// Move Piece method, moves from position a to position b
    /// </summary>
    /// <param name="from">The old position</param>
    /// <param name="to">The new position</param>
    public void MovePiece(IPosition from, IPosition to)
    {
        PieceType piece = Cells[from.Row, from.Column];
        Cells[to.Row, to.Column] = piece;
        Cells[from.Row, from.Column] = PieceType.Empty;
    }

    /// <summary>
    /// Checks if the position is valid and on the board.
    /// </summary>
    /// <param name="position">The position it is checking</param>
    /// <returns>True if it is a valid position or false if it is invalid</returns>
    public bool IsValidPosition(IPosition position)
    {
        return position.Row >= 0 && position.Row < Rows && position.Column >= 0 && position.Column < Columns;
    }

    /// <summary>
    /// Checks move against its ruleset for the piece.
    /// </summary>
    /// <param name="from">Old position</param>
    /// <param name="to">New position</param>
    /// <returns>True if it is a valid Move or false if it is invalid</returns>
    public bool IsMoveLegal(IPosition from, IPosition to)
    {
        // Not needed for the scope of level Designer.
        return IsValidPosition(to);
    }

    /// <summary>
    /// Gets the width of the board
    /// </summary>
    /// <returns>Returns integer value of the board</returns>
    public int GetBoardWidth()
    {
        return Columns;
    }

    /// <summary>
    /// Gets the height of the board
    /// </summary>
    /// <returns>Returns integer value of the board</returns>
    public int GetBoardHeight()
    {
        return Rows;
    } 
}