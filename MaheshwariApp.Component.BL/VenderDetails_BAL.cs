using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaheshwariApp.Component.DAL;
using System.Data;
namespace MaheshwariApp.Component.BL
{
   public class VenderDetails_BAL
    {
       VenderDetails_DAL VD = new VenderDetails_DAL();

       public void InsertVenderDetailsBAL(string VendorID, string VendorName, string VendorAddress, DateTime VendorAddDate, string VendorCity, string VendorEmail, Int64 VendorMobile)
       {
           VD.InsertVenderDetails(VendorID,VendorName,VendorAddress,VendorAddDate,VendorCity,VendorEmail,VendorMobile);
       }

       public DataSet ShowVendorDetailsBAL()
       {
           DataSet ds=new DataSet();
           ds=VD.ShowVendoeDetails();
           return ds;
       }

    }
}
