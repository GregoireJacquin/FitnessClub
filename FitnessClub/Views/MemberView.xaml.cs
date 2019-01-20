using FitnessClub.ViewModels;

namespace FitnessClub.Views
{
    /// <summary>
    /// Interaction logic for MenuView.xaml
    /// </summary>
    public partial class MemberView
    {
        public MemberView()
        {
            DataContext = new MemberViewModel();
            InitializeComponent();           
        }
    }
}
