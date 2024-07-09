using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace CoffeeManager.ViewModels
{
    public class ControlBarVM : BaseVM
    {
        #region Command
        public ICommand CloseWindowCommand { get; set; }
        #endregion

        public ControlBarVM()   
        {
            CloseWindowCommand = new RelayCommand<UserControl>((p) => { return true; }, (p) => { });
        }
    }
}
