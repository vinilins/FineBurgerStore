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

namespace ProjectStore
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow()
        {
            InitializeComponent();
            gridUser.ItemsSource = UserManager.GetInstance().UsersList;
            gridProducts.ItemsSource = ProductManager.GetInstance().ProductList;
            gridClient.ItemsSource = ClientManager.GetInstance().ClientList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text_button.Content = "Usuários";
            tabControl.SelectedIndex = 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            text_button.Content = "Clientes";
            tabControl.SelectedIndex = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            text_button.Content = "Produtos";
            tabControl.SelectedIndex = 2;
        }

        internal void ReloadGrid()
        {
            gridUser.ItemsSource = UserManager.GetInstance().UsersList;
            gridUser.Items.Refresh();
            gridProducts.ItemsSource = ProductManager.GetInstance().ProductList;
            gridProducts.Items.Refresh();
            gridClient.ItemsSource = ClientManager.GetInstance().ClientList;
            gridClient.Items.Refresh();
        }

        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                var CreateUserWindow = new CreateUserWindow(this);
                CreateUserWindow.Show();
            }
            else if(tabControl.SelectedIndex == 1)
            {
                var CreateClientWindow = new CreateClientWindow(this);
                CreateClientWindow.Show();
            }            
            else if (tabControl.SelectedIndex == 2)
            {
                var CreateProductWindow = new CreateProductWindow(this);
                CreateProductWindow.Show();
            }
        }

        private void ButtonDeleteUser(object sender, RoutedEventArgs e)
        {
            var buttonValue = ((Button)sender).Tag.ToString();

            if (tabControl.SelectedIndex == 0)
            {
                UserManager.GetInstance().RemoveList(buttonValue);
            }
            else if (tabControl.SelectedIndex == 1)
            {
                ClientManager.GetInstance().RemoveList(buttonValue);
            }
            else if (tabControl.SelectedIndex == 2)
            {
                ProductManager.GetInstance().RemoveList(buttonValue);
            }

            ReloadGrid();
        }
    }
}
