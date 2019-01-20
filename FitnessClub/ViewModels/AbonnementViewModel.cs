using System.Windows;
using System.Windows.Input;
using FitnessClub.Commands;
using FitnessClub.Models;
using System.Collections.Generic;

namespace FitnessClub.ViewModels
{
    public class AbonnementViewModel : ViewModelBase
    {

        #region field private
        private System.Threading.Timer _timer;
        private Member Member { get; set; }
        #endregion      

        #region Constructor
        public AbonnementViewModel(Member member)
        {
            Member = member;
            DisplayAbonnement();
            Abonnement = new Abonnement();
        }
        #endregion

        #region Requete Linq
        public void DisplayAbonnement()
        {
            PropertyAbonnement = new DataService().GetAbonnements(Member.MemberId);
        }
        #endregion

        #region DependencyProperty
        #region PropertyAbonnement
        public IEnumerable<Abonnement> PropertyAbonnement
        {
            get { return (IEnumerable<Abonnement>)GetValue(AbonnementPropertyProperty); }
            set { SetValue(AbonnementPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for AbonnementProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AbonnementPropertyProperty =
            DependencyProperty.Register("AbonnementProperty", typeof(IEnumerable<Abonnement>), typeof(AbonnementViewModel), new UIPropertyMetadata(null));
        #endregion
        #region Abonnement
        public Abonnement Abonnement
        {
            get { return (Abonnement)GetValue(AbonnementProperty); }
            set { SetValue(AbonnementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Abonnement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AbonnementProperty =
            DependencyProperty.Register("Abonnement", typeof(Abonnement), typeof(AbonnementViewModel), new UIPropertyMetadata(null));
        #endregion
        #region SelectedAbonnement
        public Abonnement SelectedAbonnement
        {
            get { return (Abonnement)GetValue(SelectedAbonnementProperty); }
            set { SetValue(SelectedAbonnementProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedAbonnement.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedAbonnementProperty =
            DependencyProperty.Register("SelectedAbonnement", typeof(Abonnement), typeof(AbonnementViewModel), new UIPropertyMetadata(null));
        #endregion
        #endregion

        #region Command
        private DelegateCommand<Abonnement> _deleteCommand;
        private DelegateCommand _addCommand;

        #region Command Delete
        public ICommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new DelegateCommand<Abonnement>(Delete,CanDelete)); }
        }

        private void Delete(Abonnement abonnement)
        {
            new DataService().DeleteAbonnement(abonnement);
            AsyncDisplayAbonnement();
        }
        private bool CanDelete(Abonnement abonnement)
        {
            if (abonnement != null)
                return true;
            return false;
        }
        #endregion
        #region Command Add
        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new DelegateCommand(Add)); }
        }

        private void Add()
        {
            new DataService().InsertAbonnement(Member.MemberId,Abonnement);
            AsyncDisplayAbonnement();
            Abonnement = new Abonnement();
        }
        #endregion
        #endregion

        #region AsyncDisplayAbonnement
        private void AsyncDisplayAbonnement()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
            
            DisplayAbonnement();
        }
        #endregion
    }
}
