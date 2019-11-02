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
    public partial class CreateUserWindow : Window
    {
        SubWindow windowSub;

        public CreateUserWindow(SubWindow subWindow)
        {
            InitializeComponent();
            windowSub = subWindow;
        }

        private void buttonNewUser_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User
            {
                Email = textboxNewUser.Text,
                Password = textbox_new_password.Text
            };

            UserManager.GetInstance().AddList(newUser);
            windowSub.ReloadGrid();

            Close();
        }
    }
}
