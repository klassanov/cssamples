using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Model
{
  [XmlRoot("Rubrica")]
  public class AddressBook
  {
    [XmlArray("ElencoClienti")]
    [XmlArrayItem("Cliente")]
    public List<Customer> Customers { get; set; }

    public AddressBook()
    {

      
      Customers = new List<Customer>();
    }

  }
}
