using System;
using System.Collections;
using System.IO;


namespace Pegaso2000.Web.Reporting
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World");
      Console.Beep();
      Console.ReadLine();

      Gatto g = new Gatto();
      Console.WriteLine(g.ToString());

      GattoSiamese s = new GattoSiamese();
      Console.WriteLine(s.ToString());

      Console.ReadLine();
      IGatto g2 = new GattoSiamese();

      Console.WriteLine(((IGatto)s).Colore);

      System.Collections.ArrayList lista = new ArrayList();
      lista.Add(1);
      lista.Add("ciao ciao");
      lista.Add(DateTime.Now);

      System.Collections.Generic.List<int> listg = 
              new System.Collections.Generic.List<int>();

      listg.Add(5);
      //listg.Add("ciao");

      int v = listg[0];

      System.Collections.Hashtable ht = new Hashtable();
      ht.Add("bello mi piace", g);
      ht.Add("non mi piace", s);

      Mesh<GattoSiamese>(s, "nonloso");
      Mesh(s, "ciaociao");

      //System.Collections.Generic

      Gatto result = ht["bello mi piace"] as Gatto;
    }

    public static void Mesh<T>(T animale, string nuovacategoria) where T:Animali
    {
      animale.Categoria = nuovacategoria;
    }

    
  }
}
