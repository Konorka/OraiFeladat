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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) { }
        public static bool eXit=false;
        public static bool saveButton = false;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
            
        }

        private void NewProductClick(object sender, RoutedEventArgs e)
        {
            var vm = new ProductFromViewModel
            {
                Product = new Product()

            };
            var form = new ProductForm
            {
                DataContext = vm

            };
            form.ShowDialog();

            if (eXit==false&&saveButton==true)
            {
                ((MainViewModel)DataContext).Products.Add(vm.Product);
            }


            
        }

       

        private void ModiProductClick(object sender, RoutedEventArgs e)
        {

            var modiProduct = ((MainViewModel)DataContext).SelectedProduct;
            if (modiProduct==null)
            {
                return;
            }
            var vm = new ProductFromViewModel
            {
                Product = modiProduct

            };
            var form = new ProductForm
            {
                DataContext = vm

            };
            form.ShowDialog();
        }

        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            var deleteProduct = ((MainViewModel)DataContext).SelectedProduct;
            ((MainViewModel)DataContext).Products.Remove(deleteProduct);

        }
    }
}
