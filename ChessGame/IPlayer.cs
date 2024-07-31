namespace ChessMaze
{
    public interface IPlayer
    {
        IPosition CurrentPosition { get; set; }
        bool CanMove(IPosition newPosition, IBoard board);
        void Move(IPosition newPosition, IBoard board);
    }
}
