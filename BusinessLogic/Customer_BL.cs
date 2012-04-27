using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DataAccess;
using System.Reflection;

namespace BusinessLogic
{
  public class Customer_BL
  {
    private static DB<Customer> _db = new DB<Customer>();

    private void InitDB()
    {
      if (_db.ObjectCreateDelegate == null)
        _db.ObjectCreateDelegate = delegate(Guid id)
        {
          Customer cc = new Customer();
          cc.Id = id;
          return cc;
        };
    }

    public List<Customer> GetCustomers()
    {
      InitDB();
      return _db.GetData(10);
    }

    public void UpdateCustomers(List<Customer> customers)
    {
    }

    public void UpdateCustomer(Customer customer)
    {
      _db.SetData(customer.Id, customer);
    
    }

    public void DeleteCustomers(List<Customer> customers)
    {

      Customer cliente = new Customer();
      cliente.GetType();

      Type tt = typeof(Customer);
      foreach (PropertyInfo pp in tt.GetProperties())
      { 
        //pp.
      }
     
    
    
    }
  }
}
