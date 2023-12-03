using Logic.Build.Pieces.Base;
using Logic.Build.Pieces.Factory;
using Logic.Utilities;
using System;

namespace Logic.Build
{
    public class Game : Publisher
    {
        public Board GameBoard { get; set; }
        public Piece CurrentPiece { get; set; }
        public Piece NextPiece { get; set; }
        public Piece SavedPiece { get; set; }

        private PieceFactory _pieceFactory;

        public void UpdateState()
        {
            if (CurrentPiece.IsPlaced())
            {
                CurrentPiece = NextPiece;
                NextPiece = _pieceFactory.CreatePiece(new Random().Next() % 7 + 1);
            }
        }

        public void Tick()
        {
            CurrentPiece.MoveDown(GameBoard.BoardState);
            UpdateState();
        }

        public void Command(Keys key)
        {
            switch(key)
            {
                case Keys.Up:
                    CurrentPiece.Rotate(GameBoard.BoardState);
                    break;
                case Keys.Down:
                    CurrentPiece.MoveDown(GameBoard.BoardState);
                    break;
                case Keys.Left:
                    CurrentPiece.MoveLeft(GameBoard.BoardState);
                    break;
                case Keys.Right:
                    CurrentPiece.MoveRight(GameBoard.BoardState);
                    break;
                case Keys.Space:
                    CurrentPiece.Drop(GameBoard.BoardState);
                    break;
                case Keys.R:
                    CurrentPiece.Rotate(GameBoard.BoardState);
                    break;
            }
        }
    }
}
