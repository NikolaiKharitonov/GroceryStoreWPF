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

namespace KharitonovHik_GroceryStore.View.Pages
{
    /// <summary>
    /// Логика взаимодействия для ListClient.xaml
    /// </summary>
    public partial class ListClient : Page
    {
        public ListClient()
        {
            InitializeComponent();
            LoadData();
        }

        private void gridDataClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void gridDataClient_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        private void LoadData()
        {
            Model.kataev2Entities1 db = new Model.kataev2Entities1();
            gridDataClient.ItemsSource = db.Client.ToList();
        }
    }
}
