using BE;
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

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // IBL bl = new BL();
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Bank a = new Bank();
                a.BankNumber = textBox1.Text;
                a.BanksName = textBox.Text;
                //David

                //Your code
                // BL.insertBank(a);
                MessageBox.Show("Data inserted in database!", "Data Insert");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, ex.Source);
            }
        }
    }
}
