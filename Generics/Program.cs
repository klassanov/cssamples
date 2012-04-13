using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
  class Program
  {
    static void Main(string[] args)
    {
      mialista<string> ll = new mialista<string>();

      ll.Add("paolo");
      ll.Add("marco");
      ll.Add("gianmaria");
      ll.Add("francesca");
      ll.Add("sara");

      ll.Cerca(delegate(string valore)
      {
        return valore.Contains("m");
      });

      ll.Cerca((valore) => valore.Contains("m"));

      ll.Cerca(v => v.Contains("m")).Cerca(v => v.Contains("o"));
      ll.Find(v => v.Contains("m"));
      ll.FindAll(v => v.Contains("m"));









      HashVsDictionaryGenerics<classedati> dati = new HashVsDictionaryGenerics<classedati>();

      dati.Add(new classedati(), "test");

      dati.cambiatemiidati += new HashVsDictionaryGenerics<classedati>.
                                  ChangeDatiHandler<classedati>(dati_cambiatemiidati);

      dati.cambiatemiidati += new HashVsDictionaryGenerics<classedati>.
                                  ChangeDatiHandler<classedati>(dati_cambiatemiidati);

      dati.cambiatemiidati += (i) =>
       {
         i.NomeUtente = i.NomeUtente + "_";
       };

      //dati.ChangeDati(new HashVsDictionaryGenerics<classedati>.ChangeDatiHandler<classedati>(dati_cambiatemiidati));
      dati.ChangeDati(null);
    }

    static void dati_cambiatemiidati(classedati item)
    {
      item.NomeUtente = item.NomeUtente + "_";
    }
  }
}
