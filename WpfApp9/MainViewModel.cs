using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp9
{
    public class MainViewModel : BaseModel
    {
        public ObservableCollection<Product> Products { get; set; }
        public MainViewModel()

        {
            Products = new ObservableCollection<Product>
                {
                    new Product {Name="Sajt", Price =2100, Quantity=1000},
            };
        }
        public Product SelectedProduct { get; set; }
    }
}


