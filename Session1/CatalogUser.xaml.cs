using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Session1
{
    /// <summary>
    /// Логика взаимодействия для CatalogUser.xaml
    /// </summary>
    public partial class CatalogUser : Window
    {
        public CatalogUser()
        {
            InitializeComponent();
        }

        private void LogoutManagerBTN_Click(object sender, RoutedEventArgs e)
        {
            MainWindow login = new MainWindow();
            login.Show();
            this.Close();
        }

        private void CartBTN_Click(object sender, RoutedEventArgs e)
        {
            Cart cartpage = new Cart();
            cartpage.Show();
            this.Close();
        }
    }
}
