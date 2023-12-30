using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class OPiece : BasePiece
    {
        public OPiece() {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Yellow),
                new Block(1, 0, Color.Yellow),
                new Block(1, 1, Color.Yellow),
                new Block(0, 1, Color.Yellow)
            };
        }

        public override void Reset()
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Yellow),
                new Block(1, 0, Color.Yellow),
                new Block(1, 1, Color.Yellow),
                new Block(0, 1, Color.Yellow)
            };
        }

        public override void Rotate(Block[,] boardState)
        {
            //do nothing
        }

        public override void Set()
        {
            Blocks = new List<Block>
            {
                new Block(4, 0, Color.Yellow),
                new Block(5, 0, Color.Yellow),
                new Block(5, 1, Color.Yellow),
                new Block(4, 1, Color.Yellow)
            };
        }
    }
}
