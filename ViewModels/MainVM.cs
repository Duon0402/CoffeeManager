using CoffeeManager.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CoffeeManager.ViewModels
{
    public class MainVM : BaseVM
    {
        public bool IsLoaded = false;
        public MainVM()
        {
            if(!IsLoaded)
            {
                IsLoaded = true;
                LoginWindow loginW = new LoginWindow();
                loginW.ShowDialog();
            }

        }
    }
}
