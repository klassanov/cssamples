using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Generics
{
  /// <summary>
  /// Questa classe contiene i miei dati. 
  /// </summary>
  public class classedati : Generics.IDati
  {
    public string NomeUtente { get; set; }
  }

  public class HashVsDictionary
  {
    private Hashtable ht = new Hashtable();
    private Dictionary<string, classedati> dict = new Dictionary<string, classedati>();

    public void Add(classedati dati)
    {
      if (!ht.ContainsKey(dati.NomeUtente))
        ht.Add(dati.NomeUtente, dati);

      if (!dict.ContainsKey(dati.NomeUtente))
        dict.Add(dati.NomeUtente, dati);
    }

    public classedati Get(string nomeutente)
    {
      if (ht.ContainsKey(nomeutente))
      {
        return ht[nomeutente] as classedati;
      }

      if (dict.ContainsKey(nomeutente))
        return dict[nomeutente];

      return null;
    }


    public void ChangeDati()
    {
      foreach (classedati item in dict.Values)
      {
        item.NomeUtente = item.NomeUtente + "_";
      }

      foreach (object item in ht.Values)
      {
        // ((classedati)item).NomeUtente = // Non va bene perchè potrebbe amandare in errore il programma se il cast fallisce
        // (item as classedati).NomeUtente // NOn va bene perchè potrei avere riferimenti null
        classedati dati = item as classedati;
        if (dati != null)
          dati.NomeUtente = dati.NomeUtente + "_";
      }

    }

  }
}
