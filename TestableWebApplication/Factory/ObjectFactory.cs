using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factory
{
  public static class ObjectFactory
  {
    private static Dictionary<Type, Type> _injections = new Dictionary<Type, Type>();

    public static T GetObject<T>() where T: class, new()
    {
      T result = null;
      if (_injections.ContainsKey(typeof(T)))
      {
        result = Activator.CreateInstance(_injections[typeof(T)]) as T;
      }
      if (result != null)
        return result;
      return new T();
    }

    public static void AddObject<T, TResult>()
      where TResult: T 
      where T: class, new()
    {
      if (!_injections.ContainsKey(typeof(T)))
        _injections.Add(typeof(T), typeof(TResult));
      else
        _injections[typeof(T)] = typeof(TResult);
    }
  }
}
