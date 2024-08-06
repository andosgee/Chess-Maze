using ChessMaze.Interfaces;
using ChessMaze.LevelDesignNS;

namespace ChessMaze
{
    public class LevelDesigner : ILevelDesigner
    {
        public IBoard Board { get; private set; }

    }
}
