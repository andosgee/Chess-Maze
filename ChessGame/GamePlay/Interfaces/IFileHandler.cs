/// <summary>
/// Provides functionality for handling file operations related to levels and games.
/// </summary>
public interface IFileHandler
{
    /// <summary>
    /// Saves a level to a specified file path.
    /// </summary>
    /// <param name="level">The level to save.</param>
    /// <param name="filePath">The file path to save the level to.</param>
    void SaveLevel(ILevel level, string filePath);

    /// <summary>
    /// Loads a level from a specified file path.
    /// </summary>
    /// <param name="filePath">The file path to load the level from.</param>
    /// <returns>The loaded level.</returns>
    ILevel LoadLevel(string filePath);

    /// <summary>
    /// Saves a game to a specified file path.
    /// </summary>
    /// <param name="game">The game to save.</param>
    /// <param name="filePath">The file path to save the game to.</param>
    void SaveGame(IGame game, string filePath);

    /// <summary>
    /// Loads a game from a specified file path.
    /// </summary>
    /// <param name="filePath">The file path to load the game from.</param>
    /// <returns>The loaded game.</returns>
    IGame LoadGame(string filePath);
}