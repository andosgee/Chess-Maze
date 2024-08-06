namespace ChessMaze.Interfaces
{
    public interface ILevel
    {
        IBoard Board { get; }
        IPosition StartPosition { get; }
        IPosition EndPosition { get; }
        IPlayer Player { get; }
        bool IsCompleted { get; }
    }
}