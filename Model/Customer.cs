using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Attibutes;
using System.Xml;
using System.Xml.Serialization;

namespace Model
{
  [XmlRoot("Cliente")]
  public class Customer
  {
    [NotPrint]
    [XmlAttribute("id")]
    public Guid Id { get; set; }

    [XmlElement("Nome")]
    public string Name { get; set; }

    [XmlElement("Cognome")]
    public string Surname { get; set; }

    [NotPrint]
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
  }
}
