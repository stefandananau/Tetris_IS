namespace Logic.Build.Blocks
{
    public class Block
    {
        public int X
        {
            get; private set;
        }
        public int Y
        {
            get; private set;
        }

        public Color Color
        {
            get; private set;
        }

        public void MoveDown()
        {
            SetPos(X, Y + 1);
        }

        public void MoveLeft()
        {
            SetPos(X - 1, Y);
        }

        public void MoveRight()
        {
            SetPos(X + 1, Y);
        }

        public void SetPos(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
