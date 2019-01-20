using System.Windows.Input;
using FitnessClub.Commands;

namespace FitnessClub.Views
{
    /// <summary>
    /// Interaction logic for ProposView.xaml
    /// </summary>
    public partial class ProposView 
    {
        public ProposView()
        {
            InitializeComponent();
            DataContext = this;
        }
        private DelegateCommand _exitCommand;

        #region Command Exit
        public ICommand ExitCommand
        {
            get { return _exitCommand ?? (_exitCommand = new DelegateCommand(Exit)); }
        }

        private void Exit()
        {
            Close();
        }
        #endregion
    }
}
