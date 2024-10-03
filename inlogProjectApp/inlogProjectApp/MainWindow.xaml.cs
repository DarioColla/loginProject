using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace inlogProjectApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (userTextBox.Text == "admin" && paswordTextBox.Text == "admin")
            {
                inlogTextBlock.Text = "U wordt ingelogd";
            }



        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {

            inlogTextBlock.Text = "";


        }
    }
}