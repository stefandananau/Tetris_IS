using Logic.Build;
using Logic.Utilities;
using System;
using System.Windows;

namespace Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, Subscriber
    {
        public MainWindow()
        {
            InitializeComponent();
            GameController.Get().AddSubscriber(this);
        }

        public void Update()
        {
            Application.Current.Dispatcher.Invoke((Action)delegate
            {
                var state = GameController.Get().GetState();
                var current = GameController.Get().GetCurrent();
                var next = GameController.Get().GetNext();
                var saved = GameController.Get().GetSaved();
                DrawingHelper.RemoveUiElements(Board);
                DrawingHelper.RemoveUiElements(Next);
                DrawingHelper.RemoveUiElements(Saved);
                foreach (var block in state)
                {
                    DrawingHelper.DrawRectangle(Board, new Point(block.X * 45, (block.Y - 2) * 45), new Point((block.X + 1) * 45, (block.Y - 1) * 45), 1, block.Color, 1);
                }
                foreach (var block in current)
                {
                    if(block.Y >= 2)
                    DrawingHelper.DrawRectangle(Board, new Point(block.X * 45, (block.Y - 2) * 45), new Point((block.X + 1) * 45, (block.Y - 1) * 45), 1, block.Color, 1);
                }
                foreach(var block in next)
                {
                    DrawingHelper.DrawRectangle(Next, new Point(block.X * 45, (block.Y + 1) * 45), new Point((block.X + 1) * 45, (block.Y + 2) * 45), 1, block.Color, 1);
                }
                foreach(var block in saved)
                {
                    DrawingHelper.DrawRectangle(Saved, new Point(block.X * 45, (block.Y + 1) * 45), new Point((block.X + 1) * 45, (block.Y + 2) * 45), 1, block.Color, 1);
                }
            });
        }
    }
}
