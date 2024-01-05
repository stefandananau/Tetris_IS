using Logic.Build.Pieces.Base;

namespace Logic.Build.Pieces.Factory
{
    public class PieceFactory
    {
        public Piece CreatePiece(int type)
        {
            return new JPiece();
            switch (type)
            {
                case 1:
                    return new IPiece();
                case 2:
                    return new JPiece();
                case 3:
                    return new LPiece();
                case 4:
                    return new OPiece();
                case 5:
                    return new SPiece();
                case 6:
                    return new TPiece();
                case 7:
                    return new ZPiece();
                default: return null;
            }
        }
    }
}
