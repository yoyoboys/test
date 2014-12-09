using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MaheshwariApp.Component.DAL;
using System.Data;

namespace MaheshwariApp.Component.BL
{
   public class CustomerEntry_BAL
    {
       CustomerEntry_DAL CE = new CustomerEntry_DAL();
    
    public void InsertCustomerEntry(string CustomerId,DateTime CustomerDate,string CustomerName,string CustomerAddress,Int64 CustomerMobileNo)
    {
        CE.InsertCustomerEntry(CustomerId, CustomerDate, CustomerName, CustomerAddress, CustomerMobileNo);
    }

    }
}
