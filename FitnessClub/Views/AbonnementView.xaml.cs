using System;
using System.Globalization;
using System.Windows;
using FitnessClub.Models;
using FitnessClub.ViewModels;

namespace FitnessClub.Views
{
    /// <summary>
    /// Interaction logic for AbonnementView.xaml
    /// </summary>
    public partial class AbonnementView
    {
        public Member SelectedMember
        {
            get { return (Member)GetValue(SelectedMemberProperty); }
            set { SetValue(SelectedMemberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedMember.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedMemberProperty =
            DependencyProperty.Register("SelectedMember", typeof(Member), typeof(AbonnementView), new UIPropertyMetadata(null, SelectedMemberChanged));

        private static void SelectedMemberChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Member member = ((AbonnementView)d).SelectedMember;
            if (member != null)
                (d as AbonnementView).MainPanel.DataContext = new AbonnementViewModel(member);

        }
        public AbonnementView()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            DateTime dateSelect = DateTime.Parse(DateDebAbon.SelectedDate.ToString());
            var index = DateTypeAbon.SelectedIndex;

            switch (index)
            {
                case 0:
                    DateFinAbon.Text = dateSelect.AddDays(31).ToString("d");
                    break;
                case 1:
                    DateFinAbon.Text = dateSelect.AddDays(91).ToString("d");
                    break;
                case 2:
                    DateFinAbon.Text = dateSelect.AddDays(181).ToString("d");
                    break;
                case 3:
                    DateFinAbon.Text = dateSelect.AddDays(366).ToString("d");
                    break;
            }
            
        }
    }
}
