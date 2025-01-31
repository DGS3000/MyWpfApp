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
    public class User
    {
        public string Login { get; set; }
        public string Pass { get; set; }

        public User(string login, string pass)
        {
            Login = login;
            Pass = pass;
        }
    }
}
