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
        private string userName = "";
        private string password = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            userName = UserInput.Text;
            password = PasswordInput.Text;
            if(userName == string.Empty || password == string.Empty) { MessageBox.Show("One or more of login fields left empty!\n Try again");return; }
            MenuWindow menu = new MenuWindow(userName, password);
            menu.Show();
            Close();
        }
    }
}
