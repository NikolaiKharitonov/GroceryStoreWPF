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
    /// Логика взаимодействия для ListPurchase.xaml
    /// </summary>
    public partial class ListPurchase : Page
    {
        public ListPurchase()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            Model.kataev2Entities1 db = new Model.kataev2Entities1();
            gridDataPurchase.ItemsSource = db.Purchase.ToList();
        }
    }
    
}
