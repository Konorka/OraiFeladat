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
        public ObservableCollection<Product> Product { get; set; }
        public MainViewModel()

        {
            Product = new ObservableCollection<Product>
                {
                    new Product {},
                    new Product {}
            };
        }
        public Product SelectedProduct { get; set; }
    }
}


