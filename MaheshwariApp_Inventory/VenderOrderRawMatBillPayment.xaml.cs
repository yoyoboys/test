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

namespace MaheshwariApp_Inventory
{
    /// <summary>
    /// Interaction logic for VenderOrderRawMatBillPayment.xaml
    /// </summary>
    public partial class VenderOrderRawMatBillPayment :UserControl
    {
        DataTable griddt = new DataTable();
        DataRow dr;


        public VenderOrderRawMatBillPayment()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddToGrid_Click(object sender, RoutedEventArgs e)
        {
            dr = griddt.NewRow();
            dr["SrNo"] = 0;
            dr["TypeOfMaterial"] =cmbTypeOfMaterial.Text;
            dr["Quantity"] = txtQuantity.Text;
            dr["Price"] =txtPrice.Text ;
            dr["TotalPrice"] = txtTotalPrice.Text;

            griddt.Rows.Add(dr);
            gdAddRawMaterial.ItemsSource = griddt.DefaultView;


        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //griddt.Columns.Add("SrNo");
            //griddt.Columns.Add("Type Of Material");
            //griddt.Columns.Add("Quantity");
            //griddt.Columns.Add("Price");
            //griddt.Columns.Add("Total Price");

        }

        private void gdAddRawMaterial_Loaded(object sender, RoutedEventArgs e)
        {
            griddt.Columns.Add("SrNo");
            griddt.Columns.Add("TypeOfMaterial");
            griddt.Columns.Add("Quantity");
            griddt.Columns.Add("Price");
            griddt.Columns.Add("TotalPrice");

            //gdAddRawMaterial.ItemsSource = griddt.DefaultView;
        }

       
    }
}
