using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model.Attibutes
{
  [AttributeUsage(AttributeTargets.Property)]
  public class NotPrintAttribute: System.Attribute
  {
  }
}
