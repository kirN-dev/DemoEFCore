using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DemoEFCore.Core
{
    public class RelayCommand : ICommand
    {
        private Action<object> _exexute;
        private Func<object, bool> _canExexute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _exexute = execute;
            _canExexute = canExecute;
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return _canExexute(parameter) || _canExexute == null;
        }

        public void Execute(object parameter)
        {
            _exexute(parameter);
        }
    }
}
