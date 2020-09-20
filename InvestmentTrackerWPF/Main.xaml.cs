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
          
        }

        private void Expenditure_Click(object sender, RoutedEventArgs e)
        {
            ExpenditureWindow _expenditureW = new ExpenditureWindow();
            _expenditureW.Show();
            this.Close();
        }

        private void Income_Click(object sender, RoutedEventArgs e)
        {
            Income _incomeWindow = new Income();
            _incomeWindow.Show();
            this.Close();
        }

        private void Balance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Balance = £{_manager.BalanceCheck()}");
        }

        private void People_Click(object sender, RoutedEventArgs e)
        {
            People _peopleWindow = new People();
            _peopleWindow.Show();
            this.Close();
        }
    }
}
