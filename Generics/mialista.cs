using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
  public class mialista<T> : List<T> 
  {
    public mialista<T> Cerca(Func<T, bool> funzionedicerca)
    {
      mialista<T> risultati = new mialista<T>();
      foreach (T item in this)
      {
        if (funzionedicerca(item))
          risultati.Add(item);
      }
      return risultati;
    }
  }
}
