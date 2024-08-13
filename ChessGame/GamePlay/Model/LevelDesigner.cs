namespace ChessMaze
{
    // Testing framework =  MSTest
    public class LevelDesigner : ILevelDesigner
    {
        /// <summary>Defines the board size in a global scope for the class.</summary>
        public Array boardSize;
        /// <summary>Defines the levels name in a global scope for the class.</summary>
        public string levelName;

        /// <summary>
        /// Constructor method for the LevelDesigner Class.
        /// </summary>
        /// <param name="width">Integer for the width of the board</param>
        /// <param name="height">Integer for the height of the board</param>
        /// <param name="name">String value for the name of the level</param>
        public LevelDesigner(int width, int height, string name)
        {
            SetBoardSize(width, height);
            SetLevelName(name);
        }

        public IBoard Board { get; private set; }

        /// <summary>
        /// Sets the Board size to the desired size set by the user.
        /// </summary>
        /// <param name="width">The width of the board.</param>
        /// <param name="height">The height of the board.</param>
        public void SetBoardSize(int width, int height)
        {
            // Re-set the board size here
            // if statement for if smaller than current dimenstions, loop through remove pieces.
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
    }
}
