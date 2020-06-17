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
    /// Interaction logic for TotalExpenditure.xaml
    /// </summary>
    public partial class TotalExpenditure : Window
    {
        private Manager _manager = new Manager();
        public TotalExpenditure()
        {
            InitializeComponent();
            DisplayTotal();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenditureWindow _ecpenditureWindow = new ExpenditureWindow();
            _ecpenditureWindow.Show();
            this.Close();
        }

        public void DisplayTotal()
        {
            var total = _manager.TotalExpenditure();
            TextTotal.Text = total.ToString();
        }
    }
}
