using System.Windows;
using FitnessClub.Views;

namespace FitnessClub
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            // Create the ViewModel and expose it using the View's DataContext
            var view = new MainView {DataContext = new ViewModels.MainViewModel()};
            view.Show();
        }
    }
}
