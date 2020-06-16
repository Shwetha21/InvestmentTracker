using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ManageAmount;

namespace InvestmentTrackerWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Manager _manager = new Manager();
        public MainWindow()
        {
            InitializeComponent();
            PopulateIncomeList();
            PopulateExpenditureList();
        }
        
        private void PopulateIncomeList()
        {
            ListBoxIncome.ItemsSource = _manager.DisplayIncome();
        }

        private void PopulateExpenditureList()
        {
            ListBoxExpenditure.ItemsSource = _manager.DisplayExpenditure();
        }

        private void Button_AddIncome(object sender, RoutedEventArgs e)
        {
            _manager.AddIncome(Int32.Parse(TextIncome.Text), DateTime.Parse(TextDay.Text));
            PopulateIncomeList();

        }

        private void Button_AddExpenditure(object sender, RoutedEventArgs e)
        {
            _manager.AddExpenditure(Int32.Parse(TextExpenditure.Text), DateTime.Parse(TextDay.Text));
            PopulateExpenditureList();
        }

        private void PopulateIncomeFields()
        {
            if (_manager.SelectedIncome != null)
            {
                TextIncome.Text = _manager.SelectedIncome.IncomeReceived.ToString();
                TextDay.Text = _manager.SelectedIncome.Day.ToString();
                TextExpenditure.Text = null;
            }
            else
            {
                TextIncome.Text = null;
                TextExpenditure.Text = null;
                TextDay.Text = null;
            }
        }

        private void PopulateExpenditureField()
        {
            if (_manager.SelectedExpenditure != null)
            {
                TextExpenditure.Text = _manager.SelectedExpenditure.ExpenseAmount.ToString();
                TextDay.Text = _manager.SelectedExpenditure.Day.ToString();
                TextIncome.Text = null;
            }
            else
            {
                TextIncome.Text = null;
                TextExpenditure.Text = null;
                TextDay.Text = null;
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

        private void ListBoxExpenditure_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListBoxExpenditure.SelectedItem != null)
            {
                _manager.SetSelectedExpenditure(ListBoxExpenditure.SelectedItem);
                PopulateExpenditureField();
            }

        }
    }
}
