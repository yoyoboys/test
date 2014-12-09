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
using WPF.MDI;

namespace MaheshwariApp_Inventory
{
    /// <summary>
    /// Interaction logic for WindowMDI.xaml
    /// </summary>
    public partial class WindowMDI : Window
    {
        public WindowMDI()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles the Click event of the menuExit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void menuExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Handles the Click event of the userRegistration control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void userRegistration_Click(object sender, RoutedEventArgs e)
        {

            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                // Title = " User Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here UserRegistration is the class that you have created for mainWindow.xaml user control.
                // Content = new UserRegistration()
                Content = new SM_CustomerInventry()
            });
        }

        /// <summary>
        /// Handles the Click event of the compRegistration control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs"/> instance containing the event data.</param>
        private void compRegistration_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new CompRegistration()
            });
        }

        /// <summary>
        /// Handles the Click event of the addMaterialType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RoutedEventArgs" /> instance containing the event data.</param>
        private void addMaterialType_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_TypeOfMaterial()
            });
        }

        private void addSubMaterialType_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_SubMaterialType()
            });
        }

        private void addSubMaterialPrice_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_SubMaterialPrice()
            });
        }

        private void addCustomerEntry_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_CustomerEntry()
            });
        }

        private void addTaxes_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_TaxEntry()
            });
        }

        private void addVender_Click(object sender, RoutedEventArgs e)
        {
            MainMdiContainer.Children.Clear();
            MainMdiContainer.Children.Add(new MdiChild()
            {
                //Title = " Company Registration",
                Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
                Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
                Style = null,
                //Here compRegistration is the class that you have created for mainWindow.xaml user control.
                Content = new AD_AddVender()
            });
        }



       private void AddVendor_Click(object sender, RoutedEventArgs e)
       {

           MainMdiContainer.Children.Clear();
           MainMdiContainer.Children.Add(new MdiChild()
           {
               //Title = " Company Registration",
               Height = (System.Windows.SystemParameters.PrimaryScreenHeight - 85),
               Width = (System.Windows.SystemParameters.PrimaryScreenWidth - 85),
               Style = null,
               //Here compRegistration is the class that you have created for mainWindow.xaml user control.
               Content = new VenderOrderRawMatBillPayment()
           });

                 }

        //private void menuHome_Click(object sender, RoutedEventArgs e)
        //{
        //    test.Children.Clear();

        //    TextBlock printTextBlock = new TextBlock();
        //    printTextBlock.Text = "Admin Menu Click!";
        //    test.Children.Add(printTextBlock);
        //  //  stackPanel1.Children.Add(printTextBlock);
        //    Button btn = new Button();
        //    btn.Content = " Admin Dynamic Button";
        //    test.Children.Add(btn);
           

        //}

        //private void menuMaster_Click(object sender, RoutedEventArgs e)
        //{
        //    test.Children.Clear();

        //    TextBlock printTextBlock = new TextBlock();
        //    printTextBlock.Text = " Master Menu Click";
        //    test.Children.Add(printTextBlock);
        //    //  stackPanel1.Children.Add(printTextBlock);
        //    Button btn = new Button();
        //    btn.Content = " Master Dynamic Button";
        //    test.Children.Add(btn);

        //    Button btn1 = new Button();
        //    btn1.Content = " Master Dynamic Button";
        //    test.Children.Add(btn1);

        //    Button btn2= new Button();
        //    btn2.Content = " Master Dynamic Button";
        //    test.Children.Add(btn2);

        //    Button btn3 = new Button();
        //    btn3.Content = " Master Dynamic Button";
        //    test.Children.Add(btn3);


        //}
       
    }
}
