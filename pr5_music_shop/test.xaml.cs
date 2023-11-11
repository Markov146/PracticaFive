using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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
    /// Логика взаимодействия для test.xaml
    /// </summary>
    public partial class test : Window
    {
        catalog_TableAdapter catalogAdapter = new catalog_TableAdapter();
        instruments_TableAdapter instruments_TableAdapter = new instruments_TableAdapter();
        musical_equipment_TableAdapter musical_equipment_ = new musical_equipment_TableAdapter();
        piano_TableAdapter piano_ = new piano_TableAdapter();
        guitar_TableAdapter guitar_TableAdapter = new guitar_TableAdapter();
        drums_TableAdapter drums_TableAdapter = new drums_TableAdapter();
        vinil_player_TableAdapter vinil_player_ = new vinil_player_TableAdapter(); 
        music_sustem_TableAdapter music_sustem_ = new music_sustem_TableAdapter();
        check_TableAdapter check_TableAdapter = new check_TableAdapter();
        workerTableAdapter workerTableAdapter = new workerTableAdapter();
        storeTableAdapter storeTableAdapter = new storeTableAdapter();
        branchTableAdapter branchTableAdapter = new branchTableAdapter();
        role_TableAdapter role_TableAdapter = new role_TableAdapter();
        int c = 0;
        MainWindow main = new MainWindow();
        int roleId;
        object id;
        int wi = 0;

        int count = 0;
        public test(int count, int rolei, int wid)
        {
            InitializeComponent();
            wi = wid;
            roleId = rolei;
            if (count == 1)
            {
                data.ItemsSource = catalogAdapter.GetData();
                c = count;
                combo.ItemsSource = instruments_TableAdapter.GetData();
                combo.DisplayMemberPath = "instruments_id";
                combo1.ItemsSource = musical_equipment_.GetData();
                combo1.DisplayMemberPath = "musical_equipment_id";
                txt_combo2.IsEnabled = false;
                combo2.IsEnabled = false;


            }
            else if (count == 2)
            {
                c = count;
                data.ItemsSource = instruments_TableAdapter.GetData();
                combo.ItemsSource = piano_.GetData();
                combo.DisplayMemberPath = "piano_id";

                combo1.ItemsSource = guitar_TableAdapter.GetData();
                combo1.DisplayMemberPath = "guitar_id";

                combo2.ItemsSource = drums_TableAdapter.GetData();
                combo2.DisplayMemberPath = "drums_id";
            }

            else if (count == 3)
            {
                c = count;
                data.ItemsSource = musical_equipment_.GetData();
                combo.ItemsSource = vinil_player_.GetData();
                combo.DisplayMemberPath = "vinil_player_id";

                combo1.ItemsSource = music_sustem_.GetData();
                combo1.DisplayMemberPath = "music_sustem_id";

                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 4)
            {
                c = count;
                data.ItemsSource = piano_.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;
                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 5)
            {
                c = count;
                data.ItemsSource = guitar_TableAdapter.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;

                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 6)
            {
                c = count;
                data.ItemsSource = drums_TableAdapter.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;

                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 7)
            {
                c = count;
                data.ItemsSource = vinil_player_.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;

                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 8)
            {
                c = count;
                data.ItemsSource = music_sustem_.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;

                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 9)
            {
                c = count;
                data.ItemsSource = check_TableAdapter.GetData();
                crate_check.IsEnabled = true;
               
                combo.IsEnabled = false;
                add.IsEnabled = false;
                edit.IsEnabled = false;
                txt_combo.IsEnabled = false;

                combo1.IsEnabled = false;
                combo2.IsEnabled = false;
                add.IsEnabled = false;
                del.IsEnabled = false;
                edit.IsEnabled = false;
                txtbox_edit.IsEnabled = false;
                txt_combo1.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 10)
            {
                c = count;
                data.ItemsSource = role_TableAdapter.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;
                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            else if (count == 11)
            {
                c = count;
                data.ItemsSource = workerTableAdapter.GetData();
                combo.ItemsSource = role_TableAdapter.GetData();
                combo.DisplayMemberPath = "role_id";
                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }
            else if (count == 12)
            {
                c = count;
                data.ItemsSource = storeTableAdapter.GetData();
                combo.ItemsSource = workerTableAdapter.GetData();
                combo.DisplayMemberPath = "worker_id";

                combo1.ItemsSource = branchTableAdapter.GetData();
                combo1.DisplayMemberPath = "branch_id";

                combo2.ItemsSource = catalogAdapter.GetData();
                combo2.DisplayMemberPath = "catalog_id";
            }
            else if (count == 13)
            {
                c = count;
                data.ItemsSource = branchTableAdapter.GetData();
                combo.IsEnabled = false;
                combo1.IsEnabled = false;
                combo2.IsEnabled = false;
                txt_combo2.IsEnabled = false;
            }

            txt_block.Text = combo.DisplayMemberPath.ToString();
            txt_block1.Text = combo1.DisplayMemberPath.ToString();
            txt_block2.Text = combo2.DisplayMemberPath.ToString();

        }

        private void combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo.Text = (combo.SelectedItem as DataRowView).Row[0].ToString();
        }

        private void combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo1.Text = (combo1.SelectedItem as DataRowView).Row[0].ToString();
        }

        private void combo2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txt_combo2.Text = (combo2.SelectedItem as DataRowView).Row[0].ToString();
        }

        private void data_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView id = (data.SelectedItem as DataRowView);
                if (combo.IsEnabled == false)
                {
                    try
                    {
                        txtbox_edit.Text = id.Row[1].ToString() + "," + id.Row[2].ToString();
                    }
                    catch
                    {
                        txtbox_edit.Text = "";
                    }
                }
                
            }
            catch
            {
                txtbox_edit.Text = "";
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (c == 1)
                {

                    if (txt_combo.Text == "")
                    {
                        catalogAdapter.InsertQuery(null, Convert.ToInt32(txt_combo1.Text));
                        data.ItemsSource = catalogAdapter.GetData();
                    }
                    else if (txt_combo1.Text == "")
                    {
                        catalogAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), null);
                        data.ItemsSource = catalogAdapter.GetData();
                    }
                    else
                    {
                        catalogAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text));
                        data.ItemsSource = catalogAdapter.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                }

                else if (c == 2)
                {

                    if (txt_combo.Text == "")
                    {
                        if (txt_combo1.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(null, null, Convert.ToInt32(txt_combo2.Text));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }

                        else if (txt_combo2.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(null, Convert.ToInt32(txt_combo1.Text), null);
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }

                        else
                        {
                            instruments_TableAdapter.InsertQuery(null, Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }
                    }
                    else if (txt_combo1.Text == "")
                    {
                        if (txt_combo.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(null, null, Convert.ToInt32(txt_combo2.Text)); ;
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }

                        else if (txt_combo2.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), null, null);
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }
                        else
                        {
                            instruments_TableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), null, Convert.ToInt32(txt_combo2.Text));
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                    }
                    else if (txt_combo2.Text == "")
                    {
                        if (txt_combo1.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), null, null);
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                        else if (txt_combo.Text == "")
                        {
                            instruments_TableAdapter.InsertQuery(null, Convert.ToInt32(txt_combo1.Text), null);
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                        else
                        {
                            instruments_TableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), null);
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                    }

                    else
                    {
                        instruments_TableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text));
                        data.ItemsSource = instruments_TableAdapter.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                    txt_combo2.Text = "";


                }

                else if (c == 3)
                {


                    if (txt_combo.Text == "")
                    {
                        musical_equipment_.InsertQuery(null, Convert.ToInt32(txt_combo1.Text));
                        data.ItemsSource = musical_equipment_.GetData();
                    }
                    else if (txt_combo1.Text == "")
                    {
                        musical_equipment_.InsertQuery(Convert.ToInt32(txt_combo.Text), null);
                        data.ItemsSource = musical_equipment_.GetData();
                    }
                    else
                    {
                        musical_equipment_.InsertQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text));
                        data.ItemsSource = musical_equipment_.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                }

                else if (c == 4)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    piano_.InsertQuery(b[0], b[1]);
                    data.ItemsSource = piano_.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 5)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    guitar_TableAdapter.InsertQuery(b[0], b[1]);
                    data.ItemsSource = guitar_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
                else if (c == 6)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    drums_TableAdapter.InsertQuery(b[0], b[1]);
                    data.ItemsSource = drums_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
                else if (c == 7)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    vinil_player_.InsertQuery(b[0], b[1]);
                    data.ItemsSource = vinil_player_.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 8)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    music_sustem_.InsertQuery(b[0], b[1]);
                    data.ItemsSource = music_sustem_.GetData();
                    txtbox_edit.Text = "";
                }



                else if (c == 10)
                {
                    string a = txtbox_edit.Text;
                    role_TableAdapter.InsertQuery(a);
                    data.ItemsSource = role_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 11)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    workerTableAdapter.InsertQuery(b[0], b[1], b[2], Convert.ToInt32(txt_combo.Text));
                    data.ItemsSource = workerTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 12)
                {
                    storeTableAdapter.InsertQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text));
                    data.ItemsSource = storeTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 13)
                {
                    string a = txtbox_edit.Text;
                    branchTableAdapter.InsertQuery(a);
                    data.ItemsSource = branchTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Неверный ввод данных");
            }
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    id = (data.SelectedItem as DataRowView).Row[0];
                }
                catch
                {
                    MessageBox.Show("Выберите строку");
                }

                if (c == 1)
                {
                    catalogAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = catalogAdapter.GetData();
                }

                else if (c == 2)
                {
                    instruments_TableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = instruments_TableAdapter.GetData();



                }

                else if (c == 3)
                {

                    musical_equipment_.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = musical_equipment_.GetData();


                }

                else if (c == 4)
                {
                    piano_.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = piano_.GetData();


                }

                else if (c == 5)
                {
                    guitar_TableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = guitar_TableAdapter.GetData();


                }
                else if (c == 6)
                {
                    drums_TableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = drums_TableAdapter.GetData();


                }
                else if (c == 7)
                {
                    vinil_player_.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = vinil_player_.GetData();


                }

                else if (c == 8)
                {
                    music_sustem_.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = music_sustem_.GetData();


                }

                else if (c == 9)
                {
                    check_TableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = check_TableAdapter.GetData();
                }

                else if (c == 10)
                {
                    role_TableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = role_TableAdapter.GetData();
                }

                else if (c == 11)
                {
                    workerTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = workerTableAdapter.GetData();
                }

                else if (c == 12)
                {
                    storeTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = storeTableAdapter.GetData();
                }

                else if (c == 13)
                {
                    branchTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    data.ItemsSource = branchTableAdapter.GetData();
                }
            }
            catch
            {
                Console.WriteLine("error");
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    id = (data.SelectedItem as DataRowView).Row[0];
                }
                catch
                {
                    MessageBox.Show("Выберите строку");
                }
                if (c == 1)
                {

                    if (txt_combo.Text == "")
                    {
                        catalogAdapter.UpdateQuery(null, Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(id));
                        data.ItemsSource = catalogAdapter.GetData();
                    }
                    else if (txt_combo1.Text == "")
                    {
                        catalogAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), null, Convert.ToInt32(id));
                        data.ItemsSource = catalogAdapter.GetData();
                    }
                    else
                    {
                        catalogAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(id));
                        data.ItemsSource = catalogAdapter.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                }

                else if (c == 2)
                {

                    if (txt_combo.Text == "")
                    {
                        if (txt_combo1.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(null, null, Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }

                        else if (txt_combo2.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(null, Convert.ToInt32(txt_combo1.Text), null, Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }

                        else
                        {
                            instruments_TableAdapter.UpdateQuery(null, Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }
                    }
                    else if (txt_combo1.Text == "")
                    {
                        if (txt_combo.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(null, null, Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id)); ;
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }

                        else if (txt_combo2.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), null, null, Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();
                        }
                        else
                        {
                            instruments_TableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), null, Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                    }
                    else if (txt_combo2.Text == "")
                    {
                        if (txt_combo1.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), null, null, Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                        else if (txt_combo.Text == "")
                        {
                            instruments_TableAdapter.UpdateQuery(null, Convert.ToInt32(txt_combo1.Text), null, Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                        else
                        {
                            instruments_TableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), null, Convert.ToInt32(id));
                            data.ItemsSource = instruments_TableAdapter.GetData();

                        }
                    }

                    else
                    {
                        instruments_TableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id));
                        data.ItemsSource = instruments_TableAdapter.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                    txt_combo2.Text = "";

                }
                else if (c == 3)
                {


                    if (txt_combo.Text == "")
                    {
                        musical_equipment_.UpdateQuery(null, Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(id));
                        data.ItemsSource = musical_equipment_.GetData();
                    }
                    else if (txt_combo1.Text == "")
                    {
                        musical_equipment_.UpdateQuery(Convert.ToInt32(txt_combo.Text), null, Convert.ToInt32(id));
                        data.ItemsSource = musical_equipment_.GetData();
                    }
                    else
                    {
                        musical_equipment_.UpdateQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(id));
                        data.ItemsSource = musical_equipment_.GetData();
                        txtbox_edit.Text = "";
                    }

                    txt_combo.Text = "";
                    txt_combo1.Text = "";
                }

                else if (c == 4)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    piano_.UpdateQuery(b[0], b[1], Convert.ToInt32(id));
                    data.ItemsSource = piano_.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 5)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    guitar_TableAdapter.UpdateQuery(b[0], b[1], Convert.ToInt32(id));
                    data.ItemsSource = guitar_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
                else if (c == 6)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    drums_TableAdapter.UpdateQuery(b[0], b[1], Convert.ToInt32(id));
                    data.ItemsSource = drums_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
                else if (c == 7)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    vinil_player_.UpdateQuery(b[0], b[1], Convert.ToInt32(id));
                    data.ItemsSource = vinil_player_.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 8)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    music_sustem_.UpdateQuery(b[0], b[1], Convert.ToInt32(id));
                    data.ItemsSource = music_sustem_.GetData();
                    txtbox_edit.Text = "";
                }



                else if (c == 10)
                {
                    string a = txtbox_edit.Text;
                    role_TableAdapter.UpdateQuery(a, Convert.ToInt32(id));
                    data.ItemsSource = role_TableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 11)
                {
                    string a = txtbox_edit.Text;
                    string[] b = a.Split(',');
                    workerTableAdapter.UpdateQuery(b[0], b[1], b[2], Convert.ToInt32(txt_combo.Text), Convert.ToInt32(id));
                    data.ItemsSource = workerTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 12)
                {
                    storeTableAdapter.UpdateQuery(Convert.ToInt32(txt_combo.Text), Convert.ToInt32(txt_combo1.Text), Convert.ToInt32(txt_combo2.Text), Convert.ToInt32(id));
                    data.ItemsSource = storeTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }

                else if (c == 13)
                {
                    string a = txtbox_edit.Text;
                    branchTableAdapter.UpdateQuery(a, Convert.ToInt32(id));
                    data.ItemsSource = branchTableAdapter.GetData();
                    txtbox_edit.Text = "";
                }
            }
            catch
            {
                Console.WriteLine("error");
            }

        }

        private void tabl_el_Click(object sender, RoutedEventArgs e)
        {
            
            salesman_table salesman_Table = new salesman_table(roleId, wi);
            salesman_Table.Show();
            this.Close();
            
        }

        private void crate_check_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string textic = (data.SelectedItem as DataRowView).Row[2].ToString();
                string summ = (data.SelectedItem as DataRowView).Row[3].ToString();
                string inp = (data.SelectedItem as DataRowView).Row[4].ToString();
                string ch = (data.SelectedItem as DataRowView).Row[5].ToString();


                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string path = desktop + "\\" + "Check_" + count.ToString() + ".txt";
                path = desktop + "\\" + "Check_" + (count.ToString() + "_1_reserve" + ".txt");
                string txt = "Магазин - " + "Music_shop" + "\n" + "Кассовый чек No_" + count.ToString() + "\n" + "Товары - " + textic + "\n" + "Общая сумма - " + summ + "\n" + "Внесено - " + inp + "\n" + "Сдача - " + ch;
                File.WriteAllText(path, txt);


                MessageBox.Show("DONE");
                count++;
            }
            catch 
            {
                MessageBox.Show("Попробуйте снова");
            }
        }


    }
}
