using Sales.Common.Models;
using Sales.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Sales.ViewModels
{
    public class ProductsViewModel : BaseViewModel
    {

        private ObservableCollection<Product> products;
        private ApiService apiService;

        public ObservableCollection<Product> Products
        {
            get { return this.products; }
            set { SetValue(ref this.products, value); }
        }


        public ProductsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadProducts();
        }

       

    }
}
