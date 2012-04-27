using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DataAccessLayer;
using Factory;

namespace BL
{
  public class CustomerBL
  {
    public List<Customer> GetCustomers(DataBase db)
    {
      return db.Select<Customer>();
    }

    public List<Customer> GetCustomers()
    {
      return ObjectFactory.GetObject<DataBase>().Select<Customer>();
    }

    public void Save(Customer customer)
    {
      Validations.IsEmail(customer.EmailAddress);
      customer.EmailAddress.IsEmail();
    }

    //public List<Customer> GetCustomers(Func<Customer, bool> filtro)
    //{ 
    
    //}
  }
}
