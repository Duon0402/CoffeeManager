using CoffeeManager.ViewModels;
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

namespace CoffeeManager.UserControlShared
{
    /// <summary>
    /// Interaction logic for ControlBarUC.xaml
    /// </summary>
    public partial class ControlBarUC : UserControl
    {
        public ControlBarVM ControlBarVM { get; set; }
        public ControlBarUC()
        {
            InitializeComponent();
            // Moi thang dung 1 VM rieng
            this.ControlBarVM = ControlBarVM = new ControlBarVM();
        }
    }
}
