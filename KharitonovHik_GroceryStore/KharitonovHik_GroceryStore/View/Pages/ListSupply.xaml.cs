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
    /// Логика взаимодействия для ListSupply.xaml
    /// </summary>
    public partial class ListSupply : Page
    {
        public ListSupply()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            Model.kataev2Entities1 db = new Model.kataev2Entities1();
            gridDataSupply.ItemsSource = db.Supply.ToList();
        }
    }

}
