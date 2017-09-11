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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for ProductForm.xaml
    /// </summary>
    public partial class ProductForm : Window
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            String textName = nameTextBox.Text;
            int price;
            int quantity;
            if (string.IsNullOrEmpty(textName))
            {
                MessageBox.Show("Töltse ki a nevet");
                return;
            }
            if (!(int.TryParse(priceTextBox.Text, out price)))
            {
                MessageBox.Show("Csak számot írjon ide");
                return;
            }
            if (int.Parse(priceTextBox.Text)==0)
            {
                MessageBox.Show("Nullánál nagyobb számot írjon");
                return;
            }
            if (!(int.TryParse(quantityTextBox.Text, out quantity)))
            {
                MessageBox.Show("Csak számot írjon ide");
                return;
            }
            if (int.Parse(quantityTextBox.Text) == 0)
            {
                MessageBox.Show("Nullánál nagyobb számot írjon");
                return;
            }
            DialogResult = false;
        }
    }
}
