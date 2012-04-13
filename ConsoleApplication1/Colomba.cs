using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pegaso2000
{
  public class Colomba: Volatili
  {

    public Colomba()
    {
      this.PuòVolare = true;
    }

    public override void Decolla()
    {
      Console.WriteLine("Coraggio buttati ce la puoi fare !!");
    }
  }
}
