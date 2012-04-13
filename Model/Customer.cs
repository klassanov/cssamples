using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
  public class Customer
  {
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public DateTime BirthDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string MobileNumber { get; set; }
  }
}
