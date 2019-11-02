using ProjectStore.Data;
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
    /// Interaction logic for createUser.xaml
    /// </summary>
    public partial class CreateClientWindow : Window
    {
        SubWindow windowSub;

        public CreateClientWindow(SubWindow subWindow)
        {
            InitializeComponent();
            windowSub = subWindow;
        }

        private void buttonNewUser_Click(object sender, RoutedEventArgs e)
        {
            Client newClient = new Client
            {
                Name = txbName.Text,
                Email = txbEmail.Text,
                PhoneNumber = txbPhone.Text
            };

            ClientManager.GetInstance().AddList(newClient);
            windowSub.ReloadGrid();

            Close();
        }
    }
}
