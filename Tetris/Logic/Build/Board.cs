using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System.Collections.Generic;

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

        public void Place(Piece piece)
        {
            foreach(var block in piece.GetBlocks())
            {
                BoardState[block.Y,block.X] = block;
            }
        }

        public void DeleteCompletedLines()
        {

        }

        public List<Block> GetBoardStateList()
        {
            var state = new List<Block>();
            foreach(var block in BoardState)
            {
                if(block == null) continue;
                state.Add(block);
            }
            return state;
        }
    }
}
