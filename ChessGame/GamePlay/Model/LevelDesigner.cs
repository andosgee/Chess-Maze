namespace ChessMaze
{
    // Testing framework =  MSTest
    public class LevelDesigner : ILevelDesigner
    {
        /// <summary>Defines the board size in a global scope for the class.</summary>
        public int[] boardSize;
        /// <summary>Defines the levels name in a global scope for the class.</summary>
        public string levelName;
        public ILevel _level;

        /// <summary>
        /// Constructor method for the LevelDesigner Class.
        /// </summary>
        /// <param name="width">Integer for the width of the board</param>
        /// <param name="height">Integer for the height of the board</param>
        /// <param name="name">String value for the name of the level</param>
        public LevelDesigner(int width, int height, string name)
        {
            CreateLevel(width, height);
            SetLevelName(name);
        }

        public IBoard Board { get; private set; }

        public ILevel CreateLevel(int width, int height)
        {
            IBoard board = new Board(width, height);
            IPosition startPosition = new Position(0, 0);
            IPosition endPosition = new Position(width - 1, height - 1);
            IPlayer player = new Player(startPosition);

            return new Level(board, startPosition, endPosition, player);
        }

        /// <summary>
        /// Sets the Board size to the desired size set by the user.
        /// </summary>
        /// <param name="width">The width of the board.</param>
        /// <param name="height">The height of the board.</param>
        public void SetBoardSize(int width, int height)
        {
            // If the board is empty, define it.
            if (boardSize == null) {
                boardSize = new int[2];
                boardSize[0] = width;
                boardSize[1] = height;
            }
            else if (boardSize[0] < width | boardSize[1] < height){
                // Loop through remove the pieces out of the new bounds
                boardSize[0] = width;
                boardSize[1] = height;
            }
        }

        /// <summary>
        /// Gets the board size
        /// </summary>
        /// <returns>Returns the board size as a array (Width x Height)</returns>
        public Array GetBoardSize()
        {
            return boardSize;
        }

        /// <summary>
        /// Sets the levels name.
        /// </summary>
        /// <param name="name">String value for the name of the level.</param>
        public void SetLevelName(string name) 
        {
            levelName = name;
        }

        /// <summary>
        /// Gets the level name.
        /// </summary>
        /// <returns>String value for the level name.</returns>
        public string GetLevelName()
        { 
            return levelName;
        }

        /// <summary>
        /// Adds a piece to the desired position as set by the user
        /// </summary>
        /// <param name="piece">The type of piece that is being placed.</param>
        /// <param name="position">The position the user wants the piece at.</param>
        /// <exception cref="ArgumentException">Thrown when the piece is not valid.</exception>
        /// <exception cref="IndexOutOfRangeException">Thrown when the position is out of bounds.</exception>
        public void PlacePiece(PieceType piece, IPosition position)
        {
            // make throw catch instead??
            if (!CheckPiece(piece))
            {
                throw new ArgumentException($"The piece '{piece}' is not a valid PieceType.", nameof(piece));
            }
            if (!CheckBounds(position))
            {
                throw new IndexOutOfRangeException("The position is out of bounds.");
            }

            // Implement the place piece on board AFTER the checks

            // Place the piece on the board
            //IPiece type = piece;
            //Board.PlacePiece(piece, position);
        }

        /// <summary>
        /// Checks if a piece is valid/
        /// </summary>
        /// <param name="piece">The user entered Piece</param>
        /// <returns>Bool</returns>
        private static bool CheckPiece(PieceType piece) 
        {
            bool _isEnum = Enum.IsDefined(typeof(PieceType), piece);
            return _isEnum;
        }
        
        /// <summary>
        /// Checks the boundary of the board before a piece is placed 
        /// </summary>
        /// <param name="position">Position that the piece is being placed at.</param>
        /// <returns>Bool depending on the lagality of the placement</returns>
        private bool CheckBounds(IPosition position)
        {
           return position.Row >= 0 && position.Row < boardSize[0] &&
                  position.Column >= 0 && position.Column < boardSize[1];
        }

        public void RemovePiece(IPosition position)
        {

        }

        public void SetStartPosition(IPosition position)
        {

        }

        public void SetEndPosition(IPosition position)
        {

        }
    }
}
