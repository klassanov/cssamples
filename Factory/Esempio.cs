using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace Factory
{
  public class Esempio
  {
    public void test()
    {
      var c = ObjectFactory.GetObject<Customer>(); // Restituisce pippo
      var p = ObjectFactory.GetObject<pippo>(); // Restituisce pippo
    }
  }
}
