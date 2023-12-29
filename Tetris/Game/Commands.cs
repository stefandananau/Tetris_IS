using Logic.Build;
using System.Linq;

namespace Game
{
    public class Commands
    {
        private RelayCommand _moveCommand;
        public RelayCommand MoveCommand
        {
            get
            {
                if (_moveCommand == null)
                    _moveCommand = new RelayCommand(Move);
                return _moveCommand;
            }
        }

        private void Move(object parameter)
        {
            var commandCharacter = parameter.ToString().FirstOrDefault();
            GameController.Get().Command(commandCharacter);
        }
    }
}
