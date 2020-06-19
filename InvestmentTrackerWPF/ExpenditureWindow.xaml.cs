using System;
using System.Collections;
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
    /// Interaction logic for ExpenditureWindow.xaml
    /// </summary>
    public partial class ExpenditureWindow : Window
    {
        private Manager _manager = new Manager();
        public ExpenditureWindow()
        {
            InitializeComponent();
            PopulateExpenditureList();
            PopulateMonthyExpenditure();
        }

        private void PopulateExpenditureList()
        {
            ListBoxExpenditure.ItemsSource = _manager.DisplayExpenditure();
        }

        private void PopulateMonthyExpenditure()
        {
            IList collection = (System.Collections.IList)_manager.Monthy_Expenditure();
            ListBoxMonth.ItemsSource = collection;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _mainW = new MainWindow();
            _mainW.Show();
            this.Close();
        }

        private void ButtonAddExpenditure_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _manager.AddExpenditure(float.Parse(TextExpenditure.Text), TextPurpose.Text);

                PopulateExpenditureList();
                PopulateMonthyExpenditure();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonDELETE_Click(object sender, RoutedEventArgs e)
        {
            _manager.Delete_Expenditure(Int32.Parse(TextId.Text));
            PopulateExpenditureList();
            PopulateMonthyExpenditure();
        }

        private void ButtonUPDATE_Click(object sender, RoutedEventArgs e)
        {
            _manager.Update_Expenditure(Int32.Parse(TextId.Text), float.Parse(TextExpenditure.Text), TextPurpose.Text);
            PopulateExpenditureList();
            PopulateMonthyExpenditure();
        }

        private void PopulateExpenditureFields()
        {
            if (_manager.SelectedExpenditure != null)
            {
                TextId.Text = _manager.SelectedExpenditure.ExpenditureId.ToString();
                TextExpenditure.Text = _manager.SelectedExpenditure.ExpenseAmount.ToString();
                TextDate.Text = _manager.SelectedExpenditure.Day.ToString();
                TextPurpose.Text = _manager.SelectedExpenditure.PurposeOfExpenditure.ToString();
            }
            else
            {
                TextId.Text = null;
                TextExpenditure.Text = null;
                TextDate.Text = null;
                TextPurpose.Text = null;
            }
        }

        private void ListBoxExpenditure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxExpenditure.SelectedItem != null)
            {
                _manager.SetSelectedExpenditure(ListBoxExpenditure.SelectedItem);
                PopulateExpenditureFields();
            }
        }

        private void ButtonTotal_Click(object sender, RoutedEventArgs e)
        {
            TotalExpenditure texpenditure = new TotalExpenditure();
            texpenditure.Show();
            this.Close();
        }

     
    }
}
