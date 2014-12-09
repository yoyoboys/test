using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MaheshwariApp.Component.DAL
{
   public class CustomerEntry_DAL
    {
       static private string MyConnection = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
       SqlConnection con = new SqlConnection(MyConnection);
       public void InsertCustomerEntry(string CustomerId,DateTime CustomerDate,string CustomerName,string CustomerAddress,Int64 CustomerMobileNo )
       {
           SqlCommand cmd = new SqlCommand("ASP_CustomerEntry", con);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.AddWithValue("@CustomerId", CustomerId.ToString());
           cmd.Parameters.AddWithValue("@CustomerDate", CustomerDate.ToShortDateString());
           cmd.Parameters.AddWithValue("@CustomerName", CustomerName.ToString());
           cmd.Parameters.AddWithValue("@CustomerAddress", CustomerAddress.ToString());
           cmd.Parameters.AddWithValue("@CustomerMobileNo",Convert.ToInt64(CustomerMobileNo));
           try
           {
               con.Open();
               cmd.ExecuteNonQuery();

           }
           catch (Exception ex)
           {

               throw ex;
           }
           finally
           {
               con.Close();
           }

       }
    }
}
