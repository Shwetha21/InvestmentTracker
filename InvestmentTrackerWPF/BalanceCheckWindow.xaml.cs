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
    /// Interaction logic for BalanceCheckWindow.xaml
    /// </summary>
    public partial class BalanceCheckWindow : Window
    {
        private Manager _manager = new Manager();
        public BalanceCheckWindow()
        {
            InitializeComponent();
            DisplayTotal();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow _mWindow = new MainWindow();
            _mWindow.Show();
            this.Close();
        }

        public void DisplayTotal()
        {
            var total = _manager.BalanceCheck();
            TextBalance.Text = total.ToString();
        }
    }
}
