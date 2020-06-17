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
    /// Interaction logic for Income.xaml
    /// </summary>
    public partial class Income : Window
    {
        private Manager _manager = new Manager();
        public Income()
        {
            InitializeComponent();
            PopulateIncomeList();
        }

        private void PopulateIncomeList()
        {
            ListBoxIncome.ItemsSource = _manager.DisplayIncome();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _mainW = new MainWindow();
            _mainW.Show();
            this.Close();
        }

        private void ButtonAddIncome_Click(object sender, RoutedEventArgs e)
        {
            _manager.AddIncome(Int32.Parse(TextIncome.Text), TextSource.Text);
            
            PopulateIncomeList();
        }

        private void ButtonDELETE_Click(object sender, RoutedEventArgs e)
        {
            _manager.Delete_Income(Int32.Parse(TextId.Text));
            PopulateIncomeList();
        }

        private void PopulateIncomeFields()
        {
            if (_manager.SelectedIncome != null)
            {
                TextId.Text = _manager.SelectedIncome.IncomeId.ToString();
                TextIncome.Text = _manager.SelectedIncome.IncomeReceived.ToString();
                TextDate.Text = _manager.SelectedIncome.Day.ToString();
                TextSource.Text = _manager.SelectedIncome.SourceOfIncome.ToString();
            }
            else
            {
                TextId.Text = null;
                TextIncome.Text = null;
                TextDate.Text = null;
                TextSource.Text = null;
            }
        }

        private void ListBoxIncome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxIncome.SelectedItem != null)
            {
                _manager.SetSelectedIncome(ListBoxIncome.SelectedItem);
                PopulateIncomeFields();
            }

        }

        private void ButtonTotal_Click(object sender, RoutedEventArgs e)
        {
            TotalIncome tIncome = new TotalIncome();
            tIncome.Show();
            this.Close();
        }

      
    }
}
