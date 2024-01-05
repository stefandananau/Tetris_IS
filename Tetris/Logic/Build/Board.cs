using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using System;
using System.Collections.Generic;
using System.Globalization;

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
            BoardState = new Block[22,10];
        }

        public void Place(Piece piece)
        {
            foreach(var block in piece.GetBlocks())
            {
                BoardState[block.Y,block.X] = block;
            }
        }

        public int DeleteCompletedLines()
        {
            var number_of_lines = 0;
            for(int i = 2; i < 22; i++)
            {
                if (IsCompleted(i))
                {
                    number_of_lines++;
                    DeleteLine(i);
                    i--;
                }
            }
            return number_of_lines;
        }

        private bool IsCompleted(int line)
        {
            for(int i = 0; i < 10; i++)
            {
                if (BoardState[line,i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void DeleteLine(int line)
        {
            for(int i = line; i > 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (BoardState[i-1,j] == null)
                    {
                        BoardState[i, j] = null;
                    }
                    else
                    {
                        BoardState[i,j] = new Block(BoardState[i-1,j]);
                    }
                }
            }
            
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

        public bool Overflows()
        {
            for(int i = 0; i < 10; i++)
            {
                if (BoardState[1,i] != null)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
