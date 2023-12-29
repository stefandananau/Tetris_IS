using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class SPiece : BasePiece
    {
        public SPiece()
        {
            Blocks = new List<Block>
            {
                new Block(0, 1, Color.Green),
                new Block(1, 0, Color.Green),
                new Block(1, 1, Color.Green),
                new Block(2, 0, Color.Green)
            };
        }

        public override void Reset()
        {
            Blocks = new List<Block>
            {
                new Block(0, 1, Color.Green),
                new Block(1, 0, Color.Green),
                new Block(1, 1, Color.Green),
                new Block(2, 0, Color.Green)
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
                new Block(0, 1, Color.Green),
                new Block(1, 0, Color.Green),
                new Block(1, 1, Color.Green),
                new Block(2, 0, Color.Green)
            };
        }
    }
}
