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

namespace KharitonovHik_GroceryStore.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для MenuSystem.xaml
    /// </summary>
    public partial class MenuSystem : Window
    {
        private Model.Users AuthUsers;
        public MenuSystem(Model.Users users)
        {
            InitializeComponent();
            AuthUsers = users;

            switch (AuthUsers.RoleID)

            {
                case 1:
                    break;
                case 2:
                    btnListUsers.Visibility = Visibility.Collapsed;
                    btnListClient.Visibility = Visibility.Collapsed;
                    btnListProvider.Visibility = Visibility.Collapsed;
                    btnListSupply.Visibility = Visibility.Collapsed;
                    btnListPurchase.Visibility = Visibility.Collapsed;
                    break;
                    
            }
        }

        private void btnListProducts_Click(object sender, RoutedEventArgs e)
        {
            Pages.ListProduct listProduct = new Pages.ListProduct();
            MainFrame.Navigate(listProduct);
        }

        private void btnListClient_Click(object sender, RoutedEventArgs e)
        {
            Pages.ListClient listClient = new Pages.ListClient();
            MainFrame.Navigate(listClient);
        }

        

        private void btnListSupply_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.ListSupply listSupply = new Pages.ListSupply();
            MainFrame.Navigate(listSupply);
        }

        private void btnListUsers_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.ListUsers listUsers = new Pages.ListUsers();
            MainFrame.Navigate(listUsers);
        }

        private void btnListPurchase_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.ListPurchase listPurchase = new Pages.ListPurchase();
            MainFrame.Navigate(listPurchase);
        }

        private void btnListProvider_Click_1(object sender, RoutedEventArgs e)
        {
            Pages.ListProvider listProvider = new Pages.ListProvider();
            MainFrame.Navigate(listProvider);
        }
    }
}
