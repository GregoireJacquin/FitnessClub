using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using FitnessClub.Commands;
using FitnessClub.Models;

namespace FitnessClub.ViewModels
{

    public class MemberViewModel : ViewModelBase
    {
        #region field private
        private System.Threading.Timer _timer;
        #endregion

        #region constructor
        public MemberViewModel()
        {
            try
            {
                DisplayMember();
                Member = new Member();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message ,"Erreur", MessageBoxButton.OK,
                                MessageBoxImage.Error);
                throw;
            }
           
        }
        #endregion

        #region Requete Linq
        private void DisplayMember()
        {     
            PropertyMembers = new DataService().GetMembers(FilterList);
        }
        #endregion

        #region DependencyProperty
        #region SelectedMember
        public Member SelectedMember
        {
            get { return (Member)GetValue(SelectedMemberProperty); }
            set { SetValue(SelectedMemberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedMember.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedMemberProperty =
            DependencyProperty.Register("SelectedMember", typeof(Member), typeof(MemberViewModel), new UIPropertyMetadata(null));

        #endregion
        #region PropertyMembers
        public IEnumerable<Member> PropertyMembers
        {
            get { return (IEnumerable<Member>)GetValue(PropertyMembersProperty); }
            set { SetValue(PropertyMembersProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PropertyMembers.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PropertyMembersProperty =
            DependencyProperty.Register("PropertyMembers", typeof(IEnumerable<Member>), typeof(MemberViewModel), new UIPropertyMetadata(null));
        #endregion
        #region Filter ListBox
        public string FilterList
        {
            get { return (string)GetValue(FilterListProperty); }
            set { SetValue(FilterListProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilterList.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilterListProperty =
            DependencyProperty.Register("FilterList", typeof(string), typeof(MemberViewModel), new UIPropertyMetadata(String.Empty, FilterTextChanged));



        private static void FilterTextChanged(DependencyObject dObject, DependencyPropertyChangedEventArgs e)
        {
            var o = (MemberViewModel)dObject;
            o.DisplayMember();
        }
        #endregion
        #region Member
        public Member Member
        {
            get { return (Member)GetValue(MemberProperty); }
            set { SetValue(MemberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Member.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MemberProperty =
            DependencyProperty.Register("Member", typeof(Member), typeof(MemberViewModel), new UIPropertyMetadata(null));
        #endregion       
        #endregion

        #region Command
        private DelegateCommand<Member> _deleteCommand;
        private DelegateCommand _addCommand;
        private DelegateCommand<Member> _updateCommand;
        private DelegateCommand _resetCommand;

        #region Command Delete
        public ICommand DeleteCommand
        {
            get { return _deleteCommand ?? (_deleteCommand = new DelegateCommand<Member>(Delete)); }
        }

        private void Delete(Member member)
        {
            new DataService().DeleteMember(member);
            AsyncDisplayMembers();
        }
        #endregion
        #region Command Add
        public ICommand AddCommand
        {
            get { return _addCommand ?? (_addCommand = new DelegateCommand(Add)); }
        }

        private void Add()
        {
            
            new DataService().InsertMember(Member);
            AsyncDisplayMembers();
            Member = new Member();
        }
        #endregion
        #region Command Update
        public ICommand UpdateCommand
        {
            get { return _updateCommand ?? (_updateCommand = new DelegateCommand<Member>(Update)); }
        }

        private void Update(Member member)
        {
            new DataService().UpdateMember(member);

        }
        #endregion
        #region Command Reset Filter
        public ICommand ResetCommand
        {
            get { return _resetCommand ?? (_resetCommand = new DelegateCommand(Reset)); }
        }
        public void Reset()
        {
            FilterList = "";
            DisplayMember();
        }
        #endregion
        #endregion

        #region AsyncDisplayMembers
        private void AsyncDisplayMembers()
        {
            if (_timer != null)
            {
                _timer.Dispose();
                _timer = null;
            }
            
            DisplayMember();
        }
        #endregion
    }
}
