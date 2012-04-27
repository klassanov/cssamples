using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Reflection;
using System.ComponentModel;
using Model.Attibutes;
using System.Xml.Serialization;
using System.Xml;

namespace Riflessi
{
  class Program
  {
    static void Main(string[] args)
    {

      Customer cc = new Customer();
      cc.Name = "Paolo";
      cc.Surname = "Possanzini";
      cc.Email = "paolo@teamdev.it";

      Customer cc2 = new Customer();
      cc2.Name = "Paolo";
      cc2.Surname = "Possanzini";
      cc2.Email = "paolo@teamdev.it";

      AddressBook rubrica = new AddressBook();
      rubrica.Customers.Add(cc);
      rubrica.Customers.Add(cc2);


      XmlSerializer xmls = new XmlSerializer(typeof(AddressBook));
      using (XmlTextWriter xmltw = new XmlTextWriter(@"c:\rubrica.xml", Encoding.UTF8))
      {
        xmls.Serialize(xmltw, rubrica);
      }
      //xmltw.Flush();
      //xmltw.Close();







      PrintToConsole(cc);

      Console.ReadLine();
    }

    [Description("Print object's properties values to the console")]
    static void PrintToConsole(object obj)
    {
      Type t = obj.GetType();

      foreach (PropertyInfo p in t.GetProperties())
      {
        var attributes = p.GetCustomAttributes(
                           typeof(NotPrintAttribute),false);

        if (attributes != null && attributes.Length > 0)
          continue;

        String name = p.Name;
        object value = p.GetValue(obj, null);

        Console.WriteLine(string.Format("{0} : {1}", name, value));
      }      
    }
  }
}
