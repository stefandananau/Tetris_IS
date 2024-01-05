using Logic.Build.Blocks;
using Logic.Build.Pieces.Base;
using Logic.Build.Pieces.Factory;
using Logic.Utilities;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Logic.Build
{
    public class GameController : Publisher
    {
        private static GameController instance;
        public static GameController Get()
        {
            if(instance == null)
            {
                instance = new GameController();
            }
            return instance;
        }

        private Board GameBoard;
        private Piece CurrentPiece;
        private Piece NextPiece;
        private Piece SavedPiece;
        private PieceFactory _pieceFactory;

        private int score;
        private bool _started;
        private bool _canSave;

        private Timer _gameThread;

        private GameController()
        {
            _started = false;
            _canSave = false;
        }
        private void StartGame()
        {
            score = 0;
            GameBoard = new Board();
            _pieceFactory = new PieceFactory();
            CurrentPiece = _pieceFactory.CreatePiece(new Random().Next() % 7 + 1);
            CurrentPiece.Set();
            NextPiece = _pieceFactory.CreatePiece(new Random().Next() % 7 + 1);
            _gameThread = new Timer(Tick, new AutoResetEvent(false), 1000, 500);
            _canSave = true;
        }
        private void UpdateState()
        {
            if (CurrentPiece.IsPlaced())
            {
                GameBoard.Place(CurrentPiece);
                GameBoard.DeleteCompletedLines();
                if (GameBoard.Overflows())
                {
                    _gameThread.Dispose();
                    _started = false;
                    return;
                }
                NextPiece.Set();
                CurrentPiece = NextPiece;
                NextPiece = _pieceFactory.CreatePiece(new Random().Next() % 7 + 1);
                _canSave = true;
                
            }
            else
            {
                CurrentPiece.MoveDown(GameBoard.BoardState);
            }

            

        }

        private void Tick(Object stateInfo)
        {
            UpdateState();
            Notify();
        }

        private void SavePiece()
        {
            _canSave = false;
            if(SavedPiece == null)
            {
                var piece = NextPiece;
                NextPiece = _pieceFactory.CreatePiece(new Random().Next() % 7 + 1);
                piece.Set();
                SavedPiece = CurrentPiece;
                CurrentPiece = piece;
                SavedPiece.Reset();
                
            }
            else
            {
                var piece = SavedPiece;
                piece.Set();
                SavedPiece = CurrentPiece;
                CurrentPiece = piece;
                SavedPiece.Reset();
                
            }

        }

        public void Command(char key)
        {
            if (!_started)
            {
                StartGame();
                _started = true;
                return;
            }
            switch(key)
            {
                case 'w':
                    CurrentPiece.Rotate(GameBoard.BoardState);
                    break;
                case 's':
                    CurrentPiece.MoveDown(GameBoard.BoardState);
                    break;
                case 'a':
                    CurrentPiece.MoveLeft(GameBoard.BoardState);
                    break;
                case 'd':
                    CurrentPiece.MoveRight(GameBoard.BoardState);
                    break;
                case ' ':
                    CurrentPiece.Drop(GameBoard.BoardState);
                    break;
                case 'q':
                    if(_canSave)
                    SavePiece(); 
                    break;
                default: throw new Exception("Key is not a command");
            }
            Notify();
        }

        public List<Block> GetState()
        {
            return GameBoard.GetBoardStateList();
        }

        public List<Block> GetCurrent()
        {
            return CurrentPiece.GetBlocks();
        }

        public List<Block> GetNext()
        {
            return NextPiece.GetBlocks();
        }

        public List<Block> GetSaved()
        {
            if(SavedPiece == null)
            {
                return new List<Block>();
            }
            return SavedPiece.GetBlocks();
        }

        public int GetScore()
        {
            return score;
        }
    }
}
