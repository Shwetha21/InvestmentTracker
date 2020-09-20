using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ManageAmount;

namespace InvestmentTrackerWPF
{
    /// <summary>
    /// Interaction logic for People.xaml
    /// </summary>
    public partial class People : Window
    {
        private Manager _manager = new Manager();
        public People()
        {
            InitializeComponent();
            PopulatePeopleList();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _mainW = new MainWindow();
            _mainW.Show();
            this.Close();
        }

        private void PopulatePeopleList()
        {
            ListBoxPeople.ItemsSource = _manager.DisplayPeople();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            if (_manager.SelectedPeople != null)
            {
                _manager.Delete_People(Int32.Parse(TextId.Text));
                PopulatePeopleList();
            }
            else
            {
                MessageBox.Show("Select entry to Delete");
            }

        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (PersonName.Text == "")
            {
                MessageBox.Show("Enter Input");
            }
            else
            {
                _manager.AddPersonName(PersonName.Text);
                PopulatePeopleList();
            }


        }

        private void ListBoxPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxPeople.SelectedItem != null)
            {
                _manager.SetSelectedPeople(ListBoxPeople.SelectedItem);
                PopulatePeopleFields();
            }

        }

        private void PopulatePeopleFields()
        {
            if (_manager.SelectedPeople != null)
            {
                TextId.Text = _manager.SelectedPeople.PeopleId.ToString();
                PersonName.Text = _manager.SelectedPeople.Name.ToString();  
            }
            else
            {
                TextId.Text = null;
                PersonName.Text = null;
            }
        }
    }
}
