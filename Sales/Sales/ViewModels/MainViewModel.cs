using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.ViewModels
{
    public class MainViewModel
    {
       
        public ProductsViewModel Prodcuts { get; set; }

        public MainViewModel()
        {
            this.Prodcuts = new ProductsViewModel();

        }
    }
}
