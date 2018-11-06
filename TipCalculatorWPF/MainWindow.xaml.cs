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

using System.Windows.Threading;

namespace TipCalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variables
        double Bill = 0;
        double Total = 0;
        double Percent = 12;

        public MainWindow()
        {
            // I made this comment to be able to commit
            InitializeComponent();
        }

        private void bt_Calculate_Click(object sender, RoutedEventArgs e)
        {
            // Makes the Percent entered a decimal
            Percent = Percent / 100;

            // Calculates the Bill with Tax
            Total = Bill + Bill * Percent;

            // Sets the txt box 'Total' as the Total variable but as a string
            Convert.ToString(Total);
            txt_Total.Text = "$" + Total;
        }

        // When the box is clicked on, removes the "Amount" text so the user can type
        private void in_BillAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            in_BillAmount.Text = "";
        }

        // When the box is clicked on, removes the "Amount" text so the user can type
        private void in_PercentAmount_GotFocus(object sender, RoutedEventArgs e)
        {
            in_PercentAmount.Text = "";
        }
        
        private void in_PercentAmount_LostFocus(object sender, RoutedEventArgs e)
        {
            // Sets the text to 0 if a none number is entered
            Double.TryParse(in_PercentAmount.Text, out Percent);

            // Changes the text to the default if an invalid character is inputted
            if (Percent <=0)
            {
                in_PercentAmount.Text = "12";
            }
        }

        private void in_BillAmount_LostFocus(object sender, RoutedEventArgs e)
        {
            Double.TryParse(in_BillAmount.Text, out Bill);
            if (Bill <=0)
            {
                in_BillAmount.Text = "Amount";
            }
        }
    }
}
