using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegaso2000
{
  public interface IGatto
  {
    Colori Colore { get; set; }
  }

  public class Gatto : Quadrupedi, IGatto
  {
     Colori IGatto.Colore { get; set; }

    public Gatto()
      : this(Colori.Nero)
    {}

    public Gatto(Colori colore)
    {
      ((IGatto)this).Colore = colore;
      if (colore == Colori.Nero)
        this.AmanoLAcqua = true;

      switch (colore)
      {
        case Colori.Nero:
          this.AmanoLAcqua = true; break;
        default: this.AmanoLAcqua = false; break;
      }

      switch (colore)
      {
        case Colori.Nero:
        case Colori.Bianco:
          this.AmanoLAcqua = true;
          break;

        case Colori.Giallo:
        case Colori.Tigrato:
        default:
          this.AmanoLAcqua = false;
          break;
      }
    }
  }

  public enum Colori
  {
    Nero = 6,
    Bianco = 0,
    Giallo = 77,
    Tigrato = 9,
  }

}
