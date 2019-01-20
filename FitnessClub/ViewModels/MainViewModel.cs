using System.Windows;
using System.Windows.Input;

using FitnessClub.Commands;
using FitnessClub.Views;

namespace FitnessClub.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private DelegateCommand _exitCommand;
        private DelegateCommand _proposCommand;

        #region Command Exit
        public ICommand ExitCommand
        {
            get { return _exitCommand ?? (_exitCommand = new DelegateCommand(Exit)); }
        }

        private void Exit()
        {
            Application.Current.Shutdown();
        }
        #endregion

        #region Command Propos
        public ICommand ProposCommand
        {
            get { return _proposCommand ?? (_proposCommand = new DelegateCommand(Propos)); }
        }

        private void Propos()
        {
            ProposView proposView = new ProposView();
            proposView.Show();
        }
        #endregion
    }
}
