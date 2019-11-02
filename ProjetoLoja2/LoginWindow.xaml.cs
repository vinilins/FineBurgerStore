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
    /// Interaction logic for ProjectStore.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, RoutedEventArgs e)
        {
            if(UserManager.GetInstance().SearchList(textbox_email.Text, textbox_password.Text))
            {
                Hide();
                var SubWindow = new SubWindow();
                SubWindow.Show();
            }
            else
            {
                label_warning.Content = "Dados Inválidos";
            }
        }
    }
}
