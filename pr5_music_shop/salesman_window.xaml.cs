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

namespace pr5_music_shop
{
    /// <summary>
    /// Логика взаимодействия для salesman_window.xaml
    /// </summary>
    public partial class salesman_window : Window
    {
        int roleId1 = 0;
        int widd = 0;
        public salesman_window(int roleId, int wid)
        {
            InitializeComponent();
            roleId1 = roleId;
            widd = wid;
        }

        private void sel_Click(object sender, RoutedEventArgs e)
        {
            kassa kassa = new kassa(roleId1, widd);
            kassa.Show();
            this.Close();
        }

        private void store_Click(object sender, RoutedEventArgs e)
        {
            salesman_table salesman_Table = new salesman_table(roleId1, widd);
            salesman_Table.Show();
            this.Close();
        }

        private void baсk_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
