using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Toji.Views
{
    internal class PageCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private readonly Frame frame;
        private readonly Type pagetype;
        private readonly bool isNoParameterOK = true;

        public PageCommand (Frame frame, Type pagetype)
        {
            this.frame = frame;
            this.pagetype = pagetype;
        }

        public PageCommand (Frame frame, Type pagetype, bool isNoParameterOK)
        {
            this.frame = frame;
            this.pagetype = pagetype;
            this.isNoParameterOK = isNoParameterOK;
        }

        public bool CanExecute(object? parameter)
        {
            if (isNoParameterOK) return true;
            if (parameter == null) return false;
            return true;
        }

        public bool CanExecute()
        {
            return isNoParameterOK;
        }

        public void Execute(object?  parameter)
        {
            frame.Navigate(pagetype, parameter);
        }

        public void Execute()
        {
            if (isNoParameterOK)
                frame.Navigate(pagetype);
            return;
        }

        public void NotifyCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
