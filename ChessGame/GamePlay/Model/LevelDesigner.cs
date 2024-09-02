namespace ChessMaze
{
    // Testing framework =  MSTest
    public class LevelDesigner : ILevelDesigner
    {
        public int[] boardSize;
        public string levelName;
        public ILevel _level;
        public Board boards;
        public IBoard Board { get; private set; }

        /// <summary>
        /// Constructor method for the LevelDesigner Class.
        /// </summary>
        /// <param name="width">Integer for the width of the board</param>
        /// <param name="height">Integer for the height of the board</param>
        /// <param name="name">String value for the name of the level</param>
        public LevelDesigner(int width, int height, string name)
        {
            if (width <= 0) throw new ArgumentOutOfRangeException(nameof(width), "Width must be greater than zero.");
            if (height <= 0) throw new ArgumentOutOfRangeException(nameof(height), "Height must be greater than zero.");
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name), "Level name cannot be null or empty.");
            _level = CreateLevel(width, height);
            boards = _level.Board as Board;
            Board = _level.Board;
            SetLevelName(name);
        }


        /// <summary>
        /// Creates a level instance with the sizing of the board provided by the user and then the default parameters for the level
        /// </summary>
        /// <param name="width">The width of the Level</param>
        /// <param name="height">The height of the Level</param>
        /// <returns>The newly created level</returns>
        public ILevel CreateLevel(int width, int height)
        {
            Board boards = new Board(width, height);
            IPosition startPosition = new Position(0, 0);
            IPosition endPosition = new Position(width - 1, height - 1);
            IPlayer player = new Player(startPosition);

            return new Level(boards, startPosition, endPosition, player);
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
        public int[] GetBoardSize()
        {
            int _width = boards.GetBoardWidth();
            int _height = boards.GetBoardHeight();
            int[] _boardSize = { _width, _height };
            return _boardSize;
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
            if (Board == null)
            {
                throw new InvalidOperationException("The Board has not been initialized.");
            }

            IPiece pieceToPlace = new Piece(piece);

            boards.PlacePiece(pieceToPlace, position);
        }

        /// <summary>
        /// Gets the Piece that is at a Given Index.
        /// </summary>
        /// <param name="position">The Position that the piece retrival is attempting to get</param>
        /// <returns>The Piece</returns>
        /// <exception cref="IndexOutOfRangeException">Throws an error if the piece is out of bounds.</exception>
        public IPiece GetPieceAt(Position position)
        {
            if (!CheckBounds(position))
            { 
                throw new IndexOutOfRangeException("The position is out of bounds.");
            }

            return boards.GetPieceAt(position);
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
            return position != null && position.Row >= 0 && position.Row < boards.GetBoardHeight() &&
                    position.Column >= 0 && position.Column < boards.GetBoardWidth();
        }

        /// <summary>
        /// Removes a Piece from the Board by setting the position as empty.
        /// </summary>
        /// <param name="position">The Position the user wants to empty</param>
        /// <exception cref="IndexOutOfRangeException">Throws Error if the position is out of bounds</exception>
        public void RemovePiece(IPosition position)
        {
            if (!CheckBounds(position))
            {
                throw new IndexOutOfRangeException("The position is out of bounds.");
            }

            PlacePiece(PieceType.Empty, position);
        }

        public void SetStartPosition(IPosition position)
        {

        }

        public void SetEndPosition(IPosition position)
        {

        }
    }
}
