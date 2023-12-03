using Logic.Build.Blocks;
using System.Collections.Generic;

namespace Logic.Build.Pieces.Base
{
    public abstract class BasePiece : Piece
    {
        private List<Block> Blocks;

        private bool isPlaced;
        
        public BasePiece() 
        {
        }


        public List<Block> GetBlocks()
        {
            return Blocks;
        }

        public void Drop(Block[,] boardState)
        {
            while (!isPlaced)
            {
                MoveDown(boardState);
            }
        }

        public void MoveDown(Block[,] boardState)
        {
            foreach(var block in Blocks)
            {
                if (boardState[block.Y + 1,block.X] != null)
                {
                    isPlaced = true;
                    return;
                }
            }

            foreach(var block in Blocks)
            {
                block.MoveDown();
            }
        }

        public void MoveLeft(Block[,] boardState)
        {
            foreach(var block in Blocks)
            {
                if (boardState[block.X - 1,block.Y] != null)
                {
                    isPlaced = true;
                    return;
                }
            }

            foreach (var block in Blocks)
            {
                block.MoveLeft();
            }
        }

        public void MoveRight(Block[,] boardState)
        {
            foreach (var block in Blocks)
            {
                if (boardState[block.X + 1,block.Y] != null)
                {
                    isPlaced = true;
                    return;
                }
            }

            foreach (var block in Blocks)
            {
                block.MoveRight();
            }
        }


        public abstract void Rotate(Block[,] boardState);

        public bool IsPlaced()
        {
            return isPlaced;
        }
    }
}
