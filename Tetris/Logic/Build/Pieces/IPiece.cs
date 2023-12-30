using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;

namespace Logic.Build.Pieces
{
    public class IPiece : BasePiece
    {
        private int mode;
        public IPiece()
        {
            mode = 0;
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Light_Blue),
                new Block(1, 0, Color.Light_Blue),
                new Block(2, 0, Color.Light_Blue),
                new Block(3, 0, Color.Light_Blue)
            };
        }

        public override void Reset()
        {
            mode = 0;
            Blocks = new List<Block>
            {
                new Block(0, 0, Color.Light_Blue),
                new Block(1, 0, Color.Light_Blue),
                new Block(2, 0, Color.Light_Blue),
                new Block(3, 0, Color.Light_Blue)
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
                    if (centery > 0 && centery < 20 && boardState[centery-1,centerx] == null && boardState[centery + 1, centerx] == null && boardState[centery + 2, centerx] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx, centery-1);
                        Blocks[1].SetPos(centerx, centery);
                        Blocks[2].SetPos(centerx, centery+1);
                        Blocks[3].SetPos(centerx, centery+2);
                    }
                    else if(centery > 0 && centery < 20  && boardState[centery - 1, centerx + 1] == null && boardState[centery, centerx + 1] == null && boardState[centery + 1, centerx + 1] == null && boardState[centery + 2, centerx + 1] == null) 
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 1, centery - 1);
                        Blocks[1].SetPos(centerx + 1, centery);
                        Blocks[2].SetPos(centerx + 1, centery + 1);
                        Blocks[3].SetPos(centerx + 1, centery + 2);
                    }
                    else if (centery > 0 && centery < 20  && boardState[centery - 1, centerx -1] == null && boardState[centery, centerx - 1] == null && boardState[centery + 1, centerx - 1] == null && boardState[centery + 2, centerx - 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx - 1, centery - 1);
                        Blocks[1].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx - 1, centery + 1);
                        Blocks[3].SetPos(centerx - 1, centery + 2);
                    }
                    else if (centery > 0 && centery < 20 && boardState[centery - 1, centerx + 2] == null && boardState[centery, centerx + 2] == null && boardState[centery + 1, centerx + 2] == null && boardState[centery + 2, centerx + 2] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 2, centery - 1);
                        Blocks[1].SetPos(centerx + 2, centery);
                        Blocks[2].SetPos(centerx + 2, centery + 1);
                        Blocks[3].SetPos(centerx + 2, centery + 2);
                    }
                    else if (centery > 1 && centery < 21 && boardState[centery - 2, centerx] == null && boardState[centery - 1, centerx] == null && boardState[centery + 1, centerx] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx, centery - 2);
                        Blocks[1].SetPos(centerx, centery - 1);
                        Blocks[2].SetPos(centerx, centery);
                        Blocks[3].SetPos(centerx, centery + 1);
                    }
                    else if (centery > 1 && centery < 21 && boardState[centery - 2, centerx + 1] == null && boardState[centery - 1, centerx + 1] == null && boardState[centery, centerx + 1] == null && boardState[centery + 1, centerx + 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 1, centery - 2);
                        Blocks[1].SetPos(centerx + 1, centery - 1);
                        Blocks[2].SetPos(centerx + 1, centery);
                        Blocks[3].SetPos(centerx + 1, centery + 1);
                    }
                    else if (centery > 1 && centery < 21 && boardState[centery - 2, centerx - 1] == null && boardState[centery - 1, centerx - 1] == null && boardState[centery, centerx - 1] == null && boardState[centery + 1, centerx - 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx - 1, centery - 2);
                        Blocks[1].SetPos(centerx - 1, centery - 1);
                        Blocks[2].SetPos(centerx - 1, centery);
                        Blocks[3].SetPos(centerx - 1, centery + 1);
                    }
                    else if (centery > 1 && centery < 20 && boardState[centery - 2, centerx + 2] == null && boardState[centery - 1, centerx + 2] == null && boardState[centery, centerx + 2] == null && boardState[centery + 1, centerx + 2] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 2, centery - 1);
                        Blocks[1].SetPos(centerx + 2, centery);
                        Blocks[2].SetPos(centerx + 2, centery + 1);
                        Blocks[3].SetPos(centerx + 2, centery + 2);
                    }
                    else if (centery > 2 && boardState[centery - 3, centerx] == null && boardState[centery - 2, centerx] == null && boardState[centery - 1, centerx] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx, centery - 3);
                        Blocks[1].SetPos(centerx, centery - 2);
                        Blocks[2].SetPos(centerx, centery - 1);
                        Blocks[3].SetPos(centerx, centery);
                    }
                    else if (centery > 2 && boardState[centery - 3, centerx + 1] == null && boardState[centery - 2, centerx + 1] == null && boardState[centery - 1, centerx + 1] == null && boardState[centery, centerx + 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 1, centery - 3);
                        Blocks[1].SetPos(centerx + 1, centery - 2);
                        Blocks[2].SetPos(centerx + 1, centery - 1);
                        Blocks[3].SetPos(centerx + 1, centery);
                    }
                    else if (centery > 2  && boardState[centery - 3, centerx - 1] == null && boardState[centery - 2, centerx - 1] == null && boardState[centery - 1, centerx - 1] == null && boardState[centery, centerx - 1] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx - 1, centery - 3);
                        Blocks[1].SetPos(centerx - 1, centery - 2);
                        Blocks[2].SetPos(centerx - 1, centery - 1);
                        Blocks[3].SetPos(centerx - 1, centery);
                    }
                    else if (centery > 2  && boardState[centery - 3, centerx + 2] == null && boardState[centery - 2, centerx + 2] == null && boardState[centery - 1, centerx + 2] == null && boardState[centery, centerx + 2] == null)
                    {
                        mode = 1;
                        Blocks[0].SetPos(centerx + 2, centery - 3);
                        Blocks[1].SetPos(centerx + 2, centery - 2);
                        Blocks[2].SetPos(centerx + 2, centery - 1);
                        Blocks[3].SetPos(centerx + 2, centery);
                    }

                    break;

                case 1:
                    if(centerx > 0 && centerx < 8 && boardState[centery, centerx - 1] == null && boardState[centery, centerx + 1] == null && boardState[centery, centerx + 2] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 1, centery);
                        Blocks[1].SetPos(centerx, centery);
                        Blocks[2].SetPos(centerx + 1, centery);
                        Blocks[3].SetPos(centerx + 2, centery);
                    }
                    else if(centerx > 1 && centerx < 9 && boardState[centery, centerx - 2] == null && boardState[centery, centerx - 1] == null && boardState[centery, centerx + 1]== null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 2, centery);
                        Blocks[1].SetPos(centerx - 1, centery);
                        Blocks[2].SetPos(centerx, centery);
                        Blocks[3].SetPos(centerx + 1, centery);
                    }
                    else if (centerx < 7 && boardState[centery, centerx + 1] == null && boardState[centery, centerx + 2] == null && boardState[centery, centerx + 3] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx, centery);
                        Blocks[1].SetPos(centerx + 1, centery);
                        Blocks[2].SetPos(centerx + 2, centery);
                        Blocks[3].SetPos(centerx + 3, centery);
                    }
                    else if (centerx > 2 && boardState[centery, centerx - 3] == null && boardState[centery, centerx - 2] == null && boardState[centery, centerx - 1] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 3, centery);
                        Blocks[1].SetPos(centerx - 2, centery);
                        Blocks[2].SetPos(centerx - 1, centery);
                        Blocks[3].SetPos(centerx, centery);
                    }
                    else if (centerx > 0 && centerx < 8 && boardState[centery - 1, centerx - 1] == null && boardState[centery - 1, centerx + 1] == null && boardState[centery - 1, centerx + 2] == null && boardState[centery - 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 1, centery - 1);
                        Blocks[1].SetPos(centerx, centery - 1);
                        Blocks[2].SetPos(centerx + 1, centery - 1);
                        Blocks[3].SetPos(centerx + 2, centery - 1);
                    }
                    else if (centerx > 1 && centerx < 9 && boardState[centery - 1, centerx - 2] == null && boardState[centery - 1, centerx - 1] == null && boardState[centery - 1, centerx + 1] == null && boardState[centery - 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 2, centery - 1);
                        Blocks[1].SetPos(centerx - 1, centery - 1);
                        Blocks[2].SetPos(centerx, centery - 1);
                        Blocks[3].SetPos(centerx + 1, centery - 1);
                    }
                    else if (centerx < 7 && boardState[centery - 1, centerx + 1] == null && boardState[centery - 1, centerx + 2] == null && boardState[centery - 1, centerx + 3] == null && boardState[centery - 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx, centery - 1);
                        Blocks[1].SetPos(centerx + 1, centery - 1);
                        Blocks[2].SetPos(centerx + 2, centery - 1);
                        Blocks[3].SetPos(centerx + 3, centery - 1);
                    }
                    else if (centerx > 2 && boardState[centery - 1, centerx - 3] == null && boardState[centery - 1, centerx - 2] == null && boardState[centery - 1, centerx - 1] == null && boardState[centery - 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 3, centery - 1);
                        Blocks[1].SetPos(centerx - 2, centery - 1);
                        Blocks[2].SetPos(centerx - 1, centery - 1);
                        Blocks[3].SetPos(centerx, centery - 1);
                    }
                    if (centerx > 0 && centerx < 8 && boardState[centery + 1, centerx - 1] == null && boardState[centery + 1, centerx + 1] == null && boardState[centery + 1, centerx + 2] == null && boardState[centery + 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 1, centery + 1);
                        Blocks[1].SetPos(centerx, centery + 1);
                        Blocks[2].SetPos(centerx + 1, centery + 1);
                        Blocks[3].SetPos(centerx + 2, centery + 1);
                    }
                    else if (centerx > 1 && centerx < 9 && boardState[centery + 1, centerx - 2] == null && boardState[centery + 1, centerx - 1] == null && boardState[centery + 1, centerx + 1] == null && boardState[centery + 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 2, centery + 1);
                        Blocks[1].SetPos(centerx - 1, centery + 1);
                        Blocks[2].SetPos(centerx, centery + 1);
                        Blocks[3].SetPos(centerx + 1, centery + 1);
                    }
                    else if (centerx < 7 && boardState[centery + 1, centerx + 1] == null && boardState[centery + 1, centerx + 2] == null && boardState[centery + 1, centerx + 3] == null && boardState[centery + 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx, centery + 1);
                        Blocks[1].SetPos(centerx + 1, centery + 1);
                        Blocks[2].SetPos(centerx + 2, centery + 1);
                        Blocks[3].SetPos(centerx + 3, centery + 1);
                    }
                    else if (centerx > 2 && boardState[centery + 1, centerx - 3] == null && boardState[centery + 1, centerx - 2] == null && boardState[centery + 1, centerx - 1] == null && boardState[centery + 1, centerx] == null)
                    {
                        mode = 0;
                        Blocks[0].SetPos(centerx - 3, centery + 1);
                        Blocks[1].SetPos(centerx - 2, centery + 1);
                        Blocks[2].SetPos(centerx - 1, centery + 1);
                        Blocks[3].SetPos(centerx, centery + 1);
                    }
                    break;
                default:
                    throw new Exception("something wrong happened");
            }
        }

        public override void Set()
        {
            mode = 0;
            Blocks = new List<Block>
            {
                new Block(3, 0, Color.Light_Blue),
                new Block(4, 0, Color.Light_Blue),
                new Block(5, 0, Color.Light_Blue),
                new Block(6, 0, Color.Light_Blue)
            };
        }
    }
}
