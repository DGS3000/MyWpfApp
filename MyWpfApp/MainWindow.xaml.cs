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

namespace MyWpfApp
{
    public partial class MainWindow : Window
    {
        AuthLogic authLogic = new AuthLogic();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string login = txtLogin.Text;
            string pass = txtPass.Password;

            if (authLogic.AuthService(login, pass))
            {
                MessageBox.Show("Успешная авторизация!");
            }
            else
            {
                MessageBox.Show("Неверные данные!");
            }
        }
    }
}