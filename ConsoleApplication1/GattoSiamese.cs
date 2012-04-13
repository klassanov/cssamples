using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegaso2000
{
  public class GattoSiamese : Gatto
  {
    //public GattoSiamese(Colori colore)
    //  : base(colore)
    //{ }

    public GattoSiamese()
      : base(Colori.Tigrato)
    { }

    public override bool Equals(object obj)
    {
      GattoSiamese secondogatto = obj as GattoSiamese;
      if (secondogatto != null)
      {
        return ((IGatto)this).Colore == ((IGatto)secondogatto).Colore;
        //if (this.Colore == secondogatto.Colore)
        //  return true;
      }

      return false;
    }

    public override string ToString()
    {
      //string risultato =  "Il mio gatto è " + this.Colore.ToString();
      string risultato = string.Format("Il mio gatto è {0} e {1}",
                                        ((IGatto)this).Colore, Colori.Giallo);



      if (this.AmanoLAcqua)
        risultato += " e ama l'acqua";
      else
        risultato += " e non ama l'acqua";


      // ternario 
      // (condizione)?(risultato true):(risultato false)

      risultato = string.Format("Il mio gatto è {0} e {1} ama l'acqua.\n\r\\",
                                      ((IGatto)this).Colore,
                                      this.AmanoLAcqua ? "" : "non");

      string filename = "c:\\test.log";
      string uri = "http:\\\\";

      string url = @"http:\\";

      StringBuilder sb = new StringBuilder();
      sb.Append("Il mio gatto è");
      sb.Append(((IGatto)this).Colore.ToString());
      sb.Append(" e ");
      sb.Append(this.AmanoLAcqua ? "" : "non");
      sb.Append(" ama l'acqua");

      risultato = sb.ToString();


      return risultato;

    }

    public new Type GetType()
    {
      return null;
    }
  }
}
