using Logic.Build.Blocks;
using System.Collections.Generic;

namespace Logic.Build.Pieces.Base
{
    public abstract class BasePiece : Piece
    {
        protected List<Block> Blocks;

        protected bool isPlaced;
        
        public BasePiece() 
        {
        }


        public List<Block> GetBlocks()
        {
            return Blocks;
        }

        public void Drop(Block[,] boardState)
        {
            if (isPlaced == true)
            {
                return;
            }
            while (!isPlaced)
            {
                MoveDown(boardState);
            }
        }

        public void MoveDown(Block[,] boardState)
        {
            if (isPlaced == true)
            {
                return;
            }
            foreach (var block in Blocks)
            {
                if (block.Y == 19 || boardState[block.Y + 1,block.X] != null)
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
            if (isPlaced == true)
            {
                return;
            }
            foreach (var block in Blocks)
            {
                if (block.X == 0 || boardState[block.Y,block.X-1] != null)
                {
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
            if(isPlaced == true)
            {
                return;
            }
            foreach (var block in Blocks)
            {
                if (block.X == 9 || boardState[block.Y, block.X + 1] != null)
                {
                    return;
                }
            }

            foreach (var block in Blocks)
            {
                block.MoveRight();
            }
        }


        public abstract void Rotate(Block[,] boardState);

        public abstract void Set();
        public abstract void Reset();

        public bool IsPlaced()
        {
            return isPlaced;
        }
    }
}
