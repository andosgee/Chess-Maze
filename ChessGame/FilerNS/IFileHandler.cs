namespace ChessMaze.FilerNS
{
    public interface IFileHandler
    {
        void SaveLevel(ILevel level, string filePath);
        ILevel LoadLevel(string filePath);
        void SaveGame(IGame game, string filePath);
        IGame LoadGame(string filePath);
    }
}