using pr5_music_shop.pr5DataSet1TableAdapters;
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
    /// Логика взаимодействия для salesman_table.xaml
    /// </summary>
    public partial class salesman_table : Window
    {
        int count = 0;
        int rolei = 0;
        int wid = 0;
        public salesman_table(int roleId1, int w)
        {
            workerTableAdapter worker = new workerTableAdapter();
            InitializeComponent();
            rolei = roleId1;
            wid = 0;
            switch (roleId1)
            {
                case 1:
                    table_role.IsEnabled = true;
                    table_worker.IsEnabled = true;
                    table_store.IsEnabled = true;
                    table_branch.IsEnabled = true;
                    break;
                case 2:


                    table_role.IsEnabled = false;
                    table_worker.IsEnabled = false;
                    table_store.IsEnabled = false;
                    table_branch.IsEnabled = false;
                    break;
            }
        }

        private void table_catalog_Click(object sender, RoutedEventArgs e)
        {
            
            
            /*string pa = "instruments_id";*/
            count = 1;
            test test = new test(count, rolei, wid);
            
            test.Show();
            this.Close();
        }

        private void table_instruments_Click(object sender, RoutedEventArgs e)
        {
            count = 2;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_musical_equipment_Click(object sender, RoutedEventArgs e)
        {
            count = 3;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_piano_Click(object sender, RoutedEventArgs e)
        {
            count = 4;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_guitar_Click(object sender, RoutedEventArgs e)
        {
            count = 5;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_drums_Click(object sender, RoutedEventArgs e)
        {
            count = 6;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_vivnil_player_Click(object sender, RoutedEventArgs e)
        {
            count = 7;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_music_sustem_Click(object sender, RoutedEventArgs e)
        {
            count = 8;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_chek_Click(object sender, RoutedEventArgs e)
        {
            count = 9;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            switch (rolei)
            {
                case 1:
                    admin_window admin_Window = new admin_window(rolei, wid);
                    admin_Window.Show();
                    this.Close();
                    break;
                case 2:
                    salesman_window salesman_Window = new salesman_window(rolei, wid);
                    salesman_Window.Show();
                    this.Close();
                    break;
            }
        }

        private void table_role_Click(object sender, RoutedEventArgs e)
        {
            count = 10;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_worker_Click(object sender, RoutedEventArgs e)
        {
            count = 11;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_store_Click(object sender, RoutedEventArgs e)
        {
            count = 12;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }

        private void table_branch_Click(object sender, RoutedEventArgs e)
        {
            count = 13;
            test test = new test(count, rolei, wid);
            test.Show();
            this.Close();
        }
    }
}
