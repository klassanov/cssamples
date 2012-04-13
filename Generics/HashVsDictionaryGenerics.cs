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
  //public class classedati
  //{
  //  public string NomeUtente { get; set; }
  //}


  public delegate void SimpleDelegate();


  public class TestDelegati
  {
    private SimpleDelegate miopuntatore;

    public TestDelegati()
    {
      miopuntatore = new SimpleDelegate(tt);
      miopuntatore();
    }

    public void tt()
    {
    }
  }

  public class HvsD<T> : HashVsDictionaryGenerics<T> where T : class, IDati, new()
  {

  }

  public class HashVsDictionaryGenerics<TValue> where TValue : class, IDati, new()
  {
    private Hashtable ht = new Hashtable();
    private Dictionary<string, TValue> dict = new Dictionary<string, TValue>();

    public TValue CreateNew(string chiave)
    {
      TValue nuovovalore = new TValue();
      this.Add(nuovovalore, chiave);
      return nuovovalore;
    }

    public void Add(TValue dati, string chiave)
    {
      if (!ht.ContainsKey(chiave))
        ht.Add(chiave, dati);

      if (!dict.ContainsKey(chiave))
        dict.Add(chiave, dati);
    }

    public TValue Get(string nomeutente)
    {
      if (ht.ContainsKey(nomeutente))
      {
        object value = ht[nomeutente];
        if (value is TValue)
          return (TValue)value;
      }

      if (dict.ContainsKey(nomeutente))
        return dict[nomeutente];

      return default(TValue);
    }

    public delegate void ChangeDatiHandler<T>(T item);
    public event ChangeDatiHandler<TValue> cambiatemiidati;

    public void ChangeDati(ChangeDatiHandler<TValue> funzionechemodificaidati)
    {
      foreach (TValue item in dict.Values)
      {
        if (funzionechemodificaidati != null)
          funzionechemodificaidati(item);

        if (cambiatemiidati != null)
          cambiatemiidati(item);
        //item.NomeUtente = item.NomeUtente + "_";S
      }

      foreach (object item in ht.Values)
      {
        // ((classedati)item).NomeUtente = // Non va bene perchè potrebbe amandare in errore il programma se il cast fallisce
        // (item as classedati).NomeUtente // NOn va bene perchè potrei avere riferimenti null
        TValue dati = item as TValue;
        if (dati != null)
          dati.NomeUtente = dati.NomeUtente + "_";
      }

    }

  }
}
