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

namespace TipCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            // I made this comment to be able to commit
            InitializeComponent();
        }

        private void bt_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Variables
            double Bill;
            double Percent = 15;
            double Total;

            // Makes the Percent entered a decimal
            Percent = Percent / 100;


            Bill = Convert.ToDouble(in_BillAmount.Text);
            Total = Bill + Bill * Percent;

            // Sets the txt box 'Total' as the Total variable but as a string
            Convert.ToString(Total);
            txt_Total.Text = "Your total with tip is $" + Total;
        }
    }
}
