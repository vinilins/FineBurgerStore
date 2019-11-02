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
    public partial class CreateProductWindow : Window
    {
        SubWindow windowSub;

        public CreateProductWindow(SubWindow subWindow)
        {
            InitializeComponent();
            windowSub = subWindow;
        }

        private void buttonNewProduct_Click(object sender, RoutedEventArgs e)
        {
            Product newProduct = new Product
            {
                Name = txbName.Text,
                Value = float.Parse(txbValue.Text),
                BarCode = int.Parse(txbBarCode.Text)
            };

            ProductManager.GetInstance().AddList(newProduct);
            windowSub.ReloadGrid();

            Close();
        }
    }
}
