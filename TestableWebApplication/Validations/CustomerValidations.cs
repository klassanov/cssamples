using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Validations
{
  public static bool IsEmail(this string email)
  {
    if (email.Contains("@") && email.Contains("."))
      return true;
    return false;
  }
}
