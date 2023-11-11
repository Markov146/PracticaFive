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
    /// Логика взаимодействия для admin_window.xaml
    /// </summary>
    public partial class admin_window : Window
    {
        int r=0;
        int widd = 0;
        public admin_window(int roleId1, int wid)
        {
            InitializeComponent();
            r = roleId1;
            widd = wid;
        }

        private void sel_Click(object sender, RoutedEventArgs e)
        {
            kassa kassa = new kassa(r, widd);
            kassa.Show();
            this.Close();
        }

        private void store_Click(object sender, RoutedEventArgs e)
        {
            salesman_table salesman_Table = new salesman_table(r, widd);
            salesman_Table.Show();
            this.Close();
        }

        private void add_table_Click(object sender, RoutedEventArgs e)
        {
            addFromJson add = new addFromJson(r, widd);
            add.Show();
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
