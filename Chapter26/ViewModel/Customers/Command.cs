using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Xaml;

namespace Customers
{
    public class Command: ICommand
    {
        private Action methodToExecute = null;
        private Func<bool> methodToDetectCanExecute = null;
        private DispatcherTimer canExecuteChangedEventTimer = null;
        public Command(Action methodToExecute, Func<bool> methodToDetectCanExecute)
        {
            this.methodToExecute = methodToExecute;
            this.methodToDetectCanExecute = methodToDetectCanExecute;

            canExecuteChangedEventTimer = new DispatcherTimer();
            canExecuteChangedEventTimer.Tick += canExecuteChangedEventTimer_Tick;
            canExecuteChangedEventTimer.Interval = new TimeSpan(0, 0, 9);
            canExecuteChangedEventTimer.Start();
        }

        public void Execute(object parameter)
        {
            this.methodToExecute();
        }

        public bool CanExecute(object parameter)
        {
            if(this.methodToDetectCanExecute == null)
            {
                return true;
            }
            else
            {
                return this.methodToDetectCanExecute();
            }
        }

        public event EventHandler CanExecuteChanged;

        void canExecuteChangedEventTimer_Tick(object sender, object e)
        {
            if(this.CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
        //public event EventHandler CanExecuteChanged;

        //public bool CanExecute(object parameter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Execute(object parameter)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
