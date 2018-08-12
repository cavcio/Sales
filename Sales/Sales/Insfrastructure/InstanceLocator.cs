using System;
using System.Collections.Generic;
using System.Text;

namespace Sales.Insfrastructure
{
    using ViewModels;


    public class InstanceLocator
    {
        #region Properties
        public MainViewModel Main
        {
            get;
            set;
        }
        #endregion


        #region Constructors
        public InstanceLocator() //se crea con ctor y luego tab 2 veces
        {
            this.Main = new MainViewModel();
        }
        #endregion

    }
}
