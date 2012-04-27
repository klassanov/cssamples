using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Factory
{
  public static class ObjectFactory
  {
    public static T GetObject<T>() where T : class, new()
    {
      // Nella mia logica voglio che se trovo un oggetto che 
      // eredita da T deve essere restituito quell'oggetto al posto di T. 

      var ass = Assembly.GetExecutingAssembly();
      foreach (var t in ass.GetTypes())
      {
        if (t.BaseType == typeof(T))
          return Activator.CreateInstance(t) as T;
      }

      // Se non trovo niente restituisco T
      return new T();
    }
  }
}
