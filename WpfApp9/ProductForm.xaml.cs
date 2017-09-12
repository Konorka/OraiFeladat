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
           MainWindow.eXit = false;
           MainWindow.saveButton = false;

        }
        
        private void SaveClick(object sender, RoutedEventArgs e)
        {
            
            String textName = nameTextBox.Text;
            int help;
            //Név
            if (string.IsNullOrEmpty(textName))
            {
                MessageBox.Show("Töltse ki a nevet");
                return;
            }
            //Ár
            if (!(int.TryParse(priceTextBox.Text, out help)))
            {
                MessageBox.Show("Csak számot írjon az árhoz");
                return;
            }
            if (int.Parse(priceTextBox.Text)==0)
            {
                MessageBox.Show("Az árhoz nullánál nagyobb számot írjon");
                return;
            }
            //Mennyiség
            if (!(int.TryParse(quantityTextBox.Text, out help)))
            {
                MessageBox.Show("Csak számot írjon a mennyiséghez");
                return;
            }
            if (int.Parse(quantityTextBox.Text) == 0)
            {
                MessageBox.Show("A mennyiséghez nullánál nagyobb számot írjon");
                return;
            }
            MainWindow.saveButton = true;
            DialogResult = false;
        }

        private void ClosingButton(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow.eXit = false;
        }


    }
}

