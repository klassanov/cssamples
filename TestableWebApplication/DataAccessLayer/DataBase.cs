using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
  public class DataBase
  {
    public virtual List<T> Select<T>()
    {
      return null;
    }

    public virtual void Update<T>(List<T> dati)
    { }

    public virtual void Insert<T>(List<T> dati)
    { }

    public virtual void Delete<T>(List<T> dati)
    { }

  }
}
