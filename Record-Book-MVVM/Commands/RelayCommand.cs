using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Record_Book_MVVM.Commands
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private Action<object> _Execute { get; set; } // Returns Void
        private Predicate<object> _CanExecute { get; set; } //returns Boolean
        public RelayCommand(Action<object> executeMethod, Predicate<object> CanEcecuteMethod)
        { 
            _Execute = executeMethod;
            _CanExecute = CanEcecuteMethod;
        }
        public bool CanExecute(object parameter)
        {
            return _CanExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _Execute(parameter);
        }
    }
}
