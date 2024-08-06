namespace ChessMaze.GameNS
{
    public interface IGame
    {
        ILevel CurrentLevel { get; }
        void LoadLevel(ILevel aLevel);
        bool MakeMove(IPosition newPosition);
        bool IsGameOver { get; }
        int GetMoveCount();
        void Undo();
        void Restart();
    }
}