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
using System.Security.Cryptography;

namespace KharitonovHik_GroceryStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static string GetHashPassword(string password)
        {
            {
                using (SHA256 sha256Hashing = SHA256.Create())
                {
                    byte[] sourceBytePassw = Encoding.UTF8.GetBytes(password);
                    byte[] hashSoursePassw = sha256Hashing.ComputeHash(sourceBytePassw);
                    string hash = BitConverter.ToString(hashSoursePassw).Replace("-", string.Empty);
                    return hash;
                }
            }
            
        }

        private void btnAuthorization_Click_1(object sender, RoutedEventArgs e)
        {
            Model.kataev2Entities1 db = new Model.kataev2Entities1();
            if (txtBoxLogin.Text == "" || txtBoxPassword.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                string cod = GetHashPassword(txtBoxPassword.Text);
                var users = db.Users.Where(a => a.Login == txtBoxLogin.Text && a.Password == cod).FirstOrDefault();


                if (users.Password == cod && users.Login == txtBoxLogin.Text)
                {

                    switch (users.RoleID)
                    {
                        case 1:
                            View.Windows.MenuSystem ws = new View.Windows.MenuSystem(users);
                            ws.Show();
                            Hide();
                            break;


                        case 2:
                            View.Windows.MenuSystem Window = new View.Windows.MenuSystem(users);
                            Window.Show();
                            Hide();
                            break;
                    }

                }
                else
                {
                    MessageBox.Show("Не верно логин или пароль");

                }

            }
        }

        private void txtBoxPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            
        }

        private void txtBoxLogin_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
