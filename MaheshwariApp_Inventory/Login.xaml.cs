using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MaheshwariApp_Inventory.ViewModel;

namespace MaheshwariApp_Inventory
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            this.ViewModel = new LoginViewModel();
        }

        public LoginViewModel ViewModel
        {
            get
            {
                return this.DataContext as LoginViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }

    }
}
