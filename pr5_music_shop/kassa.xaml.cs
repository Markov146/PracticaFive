using pr5_music_shop.pr5DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pr5_music_shop
{
    /// <summary>
    /// Логика взаимодействия для kassa.xaml
    /// </summary>
    public partial class kassa : Window
    {
        
        check_TableAdapter check_TableAdapter = new check_TableAdapter();
        workerTableAdapter workerTableAdapter = new workerTableAdapter();
        piano_TableAdapter piano_ = new piano_TableAdapter();
        guitar_TableAdapter guitar_TableAdapter = new guitar_TableAdapter();
        drums_TableAdapter drums_TableAdapter = new drums_TableAdapter();
        vinil_player_TableAdapter vinil_player_ = new vinil_player_TableAdapter();
        music_sustem_TableAdapter music_sustem_ = new music_sustem_TableAdapter();
        int ro = 0;
        int widd = 0;
        int summ = 0;
        int inp = 0;
        int ch = 0;

        int count = 0;
        public kassa(int r,int wid)
        {
            InitializeComponent();
            ro = r; widd = wid;

            combo.ItemsSource = piano_.GetData();
            combo.DisplayMemberPath = "name_";

            combo1.ItemsSource = guitar_TableAdapter.GetData();
            combo1.DisplayMemberPath = "name_";

            combo2.ItemsSource = drums_TableAdapter.GetData();
            combo2.DisplayMemberPath = "name_";

            combo3.ItemsSource = vinil_player_.GetData();
            combo3.DisplayMemberPath = "name_";

            combo4.ItemsSource = music_sustem_.GetData();
            combo4.DisplayMemberPath = "name_";
        }

        private void done_Click(object sender, RoutedEventArgs e)
        {
            string textic = combo.Text + "; " + combo1.Text + "; " + combo2.Text + "; " + combo3.Text + "; " + combo4.Text + ";";
            
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path = desktop + "\\"  + "Check_" + count.ToString() + ".txt";
            path = desktop + "\\" + "Check_" + (count.ToString() + "_1" + ".txt");
            string txt = "Music_shop" + "\n" + "Кассовый чек No_" + count.ToString() + "\n" + combo.Text + " - " + txt_combo.Text + " x" + colvo.Text + "\n" + combo1.Text + " - " + txt_combo1.Text + " x" + colvo1.Text + "\n" + combo2.Text + " - " + txt_combo2.Text + " x" + colvo2.Text + "\n" + combo3.Text + " - " + txt_combo3.Text + " x" + colvo3.Text + "\n" + combo4.Text + " - " + txt_combo4.Text + " x" + colvo4.Text + "\n" + "Итого к оплате: " + summ.ToString() + "\n" + "Внесено: " + inp.ToString() + "\n" + "Сдача: " + ch.ToString();
            File.WriteAllText(path, txt);



            try
            {
                check_TableAdapter.InsertQuery(widd, textic, summ.ToString(), inp.ToString(), ch.ToString());
                MessageBox.Show("DONE");
                count++;
            }
            catch 
            {
                check_TableAdapter.InsertQuery(Convert.ToInt32(widd), textic.ToString(), summ.ToString(), inp.ToString(), ch.ToString());
                MessageBox.Show("DONE");
                count++;
            }
            

        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            if (ro == 1)
            {
                admin_window admin_Window = new admin_window(ro, widd);
                admin_Window.Show();
                this.Close();
            }
            else if (ro == 2) 
            {
                salesman_window salesman_Table = new salesman_window(ro, widd);
                salesman_Table.Show();
                this.Close();
            }
        }


        

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo.Text = (combo.SelectedItem as DataRowView).Row[2].ToString();
            
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo1.Text = (combo1.SelectedItem as DataRowView).Row[2].ToString();
        }

        private void combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo2.Text = (combo2.SelectedItem as DataRowView).Row[2].ToString();
        }

        private void combo3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo3.Text = (combo3.SelectedItem as DataRowView).Row[2].ToString();
        }

        private void combo4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo4.Text = (combo4.SelectedItem as DataRowView).Row[2].ToString();        }

        private void done2_Click(object sender, RoutedEventArgs e)
        {
            inp = Convert.ToInt32(input.Text);
            if (inp <= 0)
            {
                MessageBox.Show("Внесите средства");
            }
            else if (inp < summ)
            {
                MessageBox.Show("Недостаточно средств");
            }
            else if (inp >= summ) 
            {
                ch = inp - summ;
                sdaha.Text = ch.ToString();
            }
        }

        private void done1_Click(object sender, RoutedEventArgs e)
        {
            summ = Convert.ToInt32(txt_combo.Text) * Convert.ToInt32(colvo.Text) + Convert.ToInt32(txt_combo1.Text) * Convert.ToInt32(colvo1.Text) + Convert.ToInt32(txt_combo2.Text) * Convert.ToInt32(colvo2.Text) + Convert.ToInt32(txt_combo3.Text) * Convert.ToInt32(colvo3.Text) + Convert.ToInt32(txt_combo4.Text) * Convert.ToInt32(colvo4.Text);
            SUMm.Text = summ.ToString();
        }
    }
}
