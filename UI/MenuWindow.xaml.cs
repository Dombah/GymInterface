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
using System.Windows.Shapes;

namespace UI
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private string userName;
        private string password;

        public MenuWindow(string userName, string password)
        {
            InitializeComponent();
            this.userName = userName;
            this.password = password;
            MessageBox.Show($"Logged in as: {userName}");
        }

        private void LogutButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
            MessageBox.Show($"Logged out as: {userName}");
        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IDButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuyButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
