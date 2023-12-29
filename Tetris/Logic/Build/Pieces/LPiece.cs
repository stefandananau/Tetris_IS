using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class LPiece : BasePiece
    {
        public LPiece() 
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Blue),
                new Block(1, 0, Color.Blue),
                new Block(2, 0, Color.Blue),
                new Block(0, 1, Color.Blue)
            };
        }

        public override void Reset()
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Blue),
                new Block(1, 0, Color.Blue),
                new Block(2, 0, Color.Blue),
                new Block(0, 1, Color.Blue)
            };
        }

        public override void Rotate(Block[,] boardState)
        {
            throw new NotImplementedException();
        }

        public override void Set()
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Blue),
                new Block(1, 0, Color.Blue),
                new Block(2, 0, Color.Blue),
                new Block(0, 1, Color.Blue)
            };
        }
    }
}
