using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class TPiece : BasePiece
    {
        private int mode = 0;
        public TPiece()
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Magenta),
                new Block(1, 0, Color.Magenta),
                new Block(2, 0, Color.Magenta),
                new Block(1, 1, Color.Magenta)
            };
        }

        public override void Reset()
        {
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Magenta),
                new Block(1, 0, Color.Magenta),
                new Block(2, 0, Color.Magenta),
                new Block(1, 1, Color.Magenta)
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
                    if(centery > 0 && boardState[centery - 1, centerx] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx, centery - 1);
                        Blocks[2].SetPos(centerx, centery + 1);
                        Blocks[3].SetPos(centerx + 1, centery);
                    }
                    else if(centery < 20 && boardState[centery + 2, centerx] == null && boardState[centery + 1, centerx + 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx, centery);
                        Blocks[1].SetPos(centerx, centery + 1);
                        Blocks[2].SetPos(centerx, centery + 2);
                        Blocks[3].SetPos(centerx + 1, centery + 1);
                    }
                    break;
                case 1:
                    if(centerx > 0 && boardState[centery, centerx - 1] == null)
                    {
                        mode = 2;
                        Blocks[0].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx + 1, centery);
                        Blocks[3].SetPos(centerx, centery - 1);
                    }
                    else if(centerx < 8 && boardState[centery, centerx + 2] == null && boardState[centery - 1, centerx + 1] == null)
                    {
                        mode = 2;
                        Blocks[0].SetPos(centerx, centery);
                        Blocks[1].SetPos(centerx + 1, centery);
                        Blocks[2].SetPos(centerx + 2, centery);
                        Blocks[3].SetPos(centerx + 1, centery - 1);
                    }
                    break;
                case 2:
                    if(centery < 21 && boardState[centery+1, centerx] == null)
                    {
                        mode = 3;
                        Blocks[0].SetPos(centerx, centery - 1);
                        Blocks[2].SetPos(centerx, centery + 1);
                        Blocks[3].SetPos(centerx - 1, centery);
                    }
                    else if (centery > 1 && boardState[centery - 2, centerx] == null && boardState[centery - 1, centerx - 1] == null)
                    {
                        mode = 3;
                        Blocks[0].SetPos(centerx, centery - 2);
                        Blocks[1].SetPos(centerx, centery - 1);
                        Blocks[2].SetPos(centerx, centery);
                        Blocks[3].SetPos(centerx - 1, centery - 1);
                    }
                    break;
                case 3:
                    if(centerx < 9 && boardState[centery, centerx + 1] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx + 1, centery);
                        Blocks[3].SetPos(centerx, centery + 1);
                    }
                    else if(centerx > 1 && boardState[centery, centerx - 2] == null && boardState[centery + 1, centerx - 1] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 2, centery);
                        Blocks[1].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx, centery);
                        Blocks[3].SetPos(centerx - 1, centery + 1);
                    }
                    break;
                default: throw new Exception("Something went wrong");
            }
        }

        public override void Set()
        {
            Blocks = new List<Block>
            {
                new Block(4, 0, Color.Magenta),
                new Block(5, 0, Color.Magenta),
                new Block(6, 0, Color.Magenta),
                new Block(5, 1, Color.Magenta)
            };
        }
    }
}
