using ChessMaze.GameNS;
using ChessMaze.Interfaces;

namespace ChessMaze
{
    public class Game : IGame
    {
        public ILevel CurrentLevel { get; private set; }
        public bool IsGameOver { get; private set; }
    }
}