using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess
{
  public class DB<T> where T: class
  {
    private Dictionary<Guid, T> _dati = new Dictionary<Guid, T>();

    public Func<Guid, T> ObjectCreateDelegate { get; set; }

    public List<T> GetData(int count) 
    {
      List<T> result = new List<T>();
      for (int i = 0; i < count; i++)
      {
        // Creo l'id
        Guid id = Guid.NewGuid();

        // Creo l'oggetto con quell'ID
        T newitem = ObjectCreateDelegate(id);

        // aggiungo l'oggetto ai risultati 
        result.Add(newitem);

        // aggiungo l'oggetto al dizionario per usi futuri. 
        _dati.Add(id, newitem);

      }
      return result;
    }
  }
}
