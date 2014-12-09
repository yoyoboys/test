using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MaheshwariApp.Component.DAL
{

    public class VenderDetails_DAL
    {
        static private string MyConnection = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection con = new SqlConnection(MyConnection);
        public void InsertVenderDetails(string VendorID, string VendorName, string VendorAddress, DateTime VendorAddDate, string VendorCity, string VendorEmail, Int64 VendorMobile)
        {


            SqlCommand cmd = new SqlCommand("ASP_VenderDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@VendorID", VendorID.ToString());
            cmd.Parameters.AddWithValue("@VendorName", VendorName.ToString());
            cmd.Parameters.AddWithValue("@VendorAddress", VendorAddress.ToString());
            cmd.Parameters.AddWithValue("@VendorAddDate", VendorAddDate.ToShortDateString());
            cmd.Parameters.AddWithValue("@VendorCity", VendorCity.ToString());
            cmd.Parameters.AddWithValue("@VendorEmail", VendorEmail.ToString());
            cmd.Parameters.AddWithValue("@VendorMobile", Convert.ToInt64(VendorMobile));

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


        public DataSet ShowVendoeDetails()
        {

            SqlCommand cmd = new SqlCommand("SP_VendorDetailsShow", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;

        }


    }
}
