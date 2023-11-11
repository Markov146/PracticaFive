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
using pr5_music_shop.pr5DataSet1TableAdapters;


namespace pr5_music_shop
{
    /// <summary>
    /// Логика взаимодействия для addFromJson.xaml
    /// </summary>
    public partial class addFromJson : Window
    {
        piano_TableAdapter piano_ = new piano_TableAdapter();
        guitar_TableAdapter guitar_TableAdapter = new guitar_TableAdapter();
        drums_TableAdapter drums_TableAdapter = new drums_TableAdapter();
        vinil_player_TableAdapter vinil_player_ = new vinil_player_TableAdapter();
        music_sustem_TableAdapter music_sustem_ = new music_sustem_TableAdapter();
        int ro = 0;
        int wi = 0;
        public addFromJson(int r, int w)
        {
            InitializeComponent();
            ro = r; wi = w;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            List<my_type> list = convert.DeserializeObject<List<my_type>>();
            foreach (var item in list)
            {
                if (piano.IsChecked == true)
                {

                    piano_.InsertQuery(item.name, item.price);
                }
                else if (guitar.IsChecked == true)
                {
                    guitar_TableAdapter.InsertQuery(item.name, item.price);
                }
                else if (drums.IsChecked == true)
                {
                    drums_TableAdapter.InsertQuery(item.name, item.price);
                }
                else if (vinil.IsChecked == true)
                {
                    vinil_player_.InsertQuery(item.name, item.price);
                }
                else if (music_system.IsChecked == true)
                {
                    music_sustem_.InsertQuery(item.name, item.price);
                }
            }
            MessageBox.Show("готово");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            admin_window admin_Window = new admin_window(ro, wi);
            admin_Window.Show();
            this.Close();
        }
    }
}
