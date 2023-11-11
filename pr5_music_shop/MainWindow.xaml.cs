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
using System.Windows.Navigation;
using System.Windows.Shapes;
using pr5_music_shop.pr5DataSet1TableAdapters;

namespace pr5_music_shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        workerTableAdapter worker = new workerTableAdapter();
        public string log;
        public string pas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void but_Click(object sender, RoutedEventArgs e)
        {
            var autentific = worker.GetData().Rows;

            for (int i = 0; i < autentific.Count; i++)
            {
                if (autentific[i][2].ToString() == login.Text &&
                    autentific[i][3].ToString() == password.Password)
                {
                    int roleId = (int)autentific[i][4];

                    log = login.Text;
                    pas = password.Password;
                    int wid = (int)autentific[i][0];
                    

                    switch (roleId)
                    {
                        case 1:
                            admin_window admin_Window = new admin_window(roleId, wid);
                            admin_Window.Show();
                            this.Close();
                            break;
                        case 2:
                            salesman_window salesman_Window = new salesman_window(roleId, wid);
                            salesman_Window.Show();
                            this.Close();
                            break;
                    }
                    break;
                }
                else if (i + 1 == autentific.Count)
                {
                    MessageBox.Show("Неверный логин или пароль");
                    break;
                }
            }
        }
    }
}
