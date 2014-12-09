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
using System.Data;
using MaheshwariApp.Component.BL;

namespace MaheshwariApp_Inventory
{
    /// <summary>
    /// Interaction logic for AD_CustomerEntry.xaml
    /// </summary>
    public partial class AD_CustomerEntry : UserControl
    {
        public AD_CustomerEntry()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            string CustomerId = txtCutomerId.Text;
            DateTime CustomerDate = Convert.ToDateTime(txtCustomerDate.Text);
            string CustomerName = txtCutomerName.Text;
            string CustomerAddress = txtCustomerAddress.Text;
            Int64 CustomerMobileNo =Convert.ToInt64(txtCustomerMobileNo.Text);
            try
            {
                CustomerEntry_BAL CEBAL = new CustomerEntry_BAL();
                CEBAL.InsertCustomerEntry(CustomerId, CustomerDate, CustomerName, CustomerAddress, CustomerMobileNo);
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
