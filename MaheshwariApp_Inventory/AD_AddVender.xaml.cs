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
using MaheshwariApp.Component.BL;
using System.Data;

namespace MaheshwariApp_Inventory
{
    /// <summary>
    /// Interaction logic for AD_AddVender.xaml
    /// </summary>
    public partial class AD_AddVender : UserControl
    {
        public AD_AddVender()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

           
            string VendorID=txtVenderId.Text;
            string VendorName=txtVenderName.Text;
            string VendorAddress=txtVenderAddress.Text;
            DateTime VendorAddDate=Convert.ToDateTime(txtVenderAddDate.Text);
            string VendorCity=txtVenderCity.Text;
            string VendorEmail=txtVenderEmailId.Text;
            Int64 VendorMobile=Convert.ToInt64(txtVenderMobileNo.Text);

            try
            {
                VenderDetails_BAL VDBAL = new VenderDetails_BAL();
                VDBAL.InsertVenderDetailsBAL(VendorID, VendorName, VendorAddress, VendorAddDate, VendorCity, VendorEmail, VendorMobile);
                MessageBox.Show("Data Inserted Successfully");
            }
            catch (Exception ex)
            {
                throw ex;
            }

           // AD_AddVender12_Loaded();

        }

        
        private void AD_AddVender_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                VenderDetails_BAL VDBAL = new VenderDetails_BAL();

                DataSet ds = VDBAL.ShowVendorDetailsBAL();
               dgVenderDetails.ItemsSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {
                
                throw;
            }

        }

        private void AD_AddVender_Loaded_1(object sender, RoutedEventArgs e)
        {

        }

        private void AD_AddVender12_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                VenderDetails_BAL VDBAL = new VenderDetails_BAL();

                DataSet ds = VDBAL.ShowVendorDetailsBAL();
                dgVenderDetails.ItemsSource = ds.Tables[0].DefaultView;

            }
            catch (Exception ex)
            {

                throw;
            }
        }
        //private void mdiChild_Loaded(object sender, RoutedEventArgs e)
        //{

        //}
    }
}
