using Logic.Build.Blocks;
using System.Collections.Generic;

namespace Logic.Build.Pieces.Base
{
    public interface Piece
    {
        void Drop(Block[,] boardState);
        void MoveDown(Block[,] boardState);
        void MoveLeft(Block[,] boardState);
        void MoveRight(Block[,] boardState);
        void Rotate(Block[,] boardState);
        void Set();
        void Reset();
        bool IsPlaced();
        List<Block> GetBlocks();
    }
}
