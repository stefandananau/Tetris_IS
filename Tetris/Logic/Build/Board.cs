using Logic.Build.Blocks;

namespace Logic.Build
{
    public class Board
    {
        public Block[,] BoardState
        {
            get; set;
        }
        public Board() 
        {
            BoardState = new Block[20,10];
        }
    }
}
