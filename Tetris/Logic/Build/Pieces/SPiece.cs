using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class SPiece : BasePiece
    {
        private int mode = 0;
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
            if (isPlaced)
            {
                return;
            }
            var centerx = Blocks[1].X;
            var centery = Blocks[1].Y;
            switch (mode)
            {
                case 0:
                    if (centery > 0 && boardState[centery, centerx - 1] == null && boardState[centery - 1, centerx - 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx - 1, centery - 1);
                        Blocks[3].SetPos(centerx - 1, centery);
                    }
                    else if (centery < 20 && boardState[centery + 2, centerx] == null && boardState[centery, centerx - 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx - 1, centery);
                        Blocks[1].SetPos(centerx, centery + 1);
                        Blocks[2].SetPos(centerx, centery + 2);
                        Blocks[3].SetPos(centerx - 1, centery + 1);
                    }
                    break;
                case 1:
                    if(centerx < 9 && boardState[centery, centerx + 1] == null && boardState[centery + 1, centerx - 1] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 1, centery + 1);
                        Blocks[3].SetPos(centerx + 1, centery);
                    }
                    else if(centerx > 1 && boardState[centery + 1, centerx - 1] == null && boardState[centery + 1, centerx - 2] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 2, centery + 1);
                        Blocks[1].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx - 1, centery + 1);
                        Blocks[3].SetPos(centerx, centery);
                    }
                    break;
            }
        }

        public override void Set()
        {
            Blocks = new List<Block>
            {
                new Block(4, 1, Color.Green),
                new Block(5, 0, Color.Green),
                new Block(5, 1, Color.Green),
                new Block(6, 0, Color.Green)
            };
        }
    }
}
