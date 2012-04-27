using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BL;
using DataAccessLayer;
using Factory;

namespace TestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void GetCustomer1()
    {
      CustomerBL bl = new CustomerBL();
      bl.GetCustomers(new DataBaseMock());
    }

    [TestMethod]
    public void GetCustomer2()
    {
      CustomerBL bl = new CustomerBL();
      bl.GetCustomers();
    }

    [TestInitialize]
    public void TestInit()
    {
      ObjectFactory.AddObject<DataBase, DataBaseMock>();
    }
  }

  public class DataBaseMock : DataBase
  {
    public override List<T> Select<T>()
    {
      return null;
    }

    public override void Delete<T>(List<T> dati)
    {
    }

    public override void Insert<T>(List<T> dati)
    {
    }

    public override void Update<T>(List<T> dati)
    {
    }
  }
}
